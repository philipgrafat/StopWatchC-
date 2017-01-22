using System;
using System.Linq;
using System.Timers;
using StopWatch.Model;

namespace StopWatch.Presenter
{
    public class StopWatchPresenter
    {
        private IView _view;
        private StopWatchModel _model;
        private Timer timer;
        private bool _isStopWatchEnabled;

        public StopWatchPresenter(IView view, StopWatchModel model)
        {
            _view = view;
            _model = model;

            _view.OnToggleButtonPressed += ToggleButtonPressed;
            _view.OnLapsButtonPressed += LapButtonPressed;
            _view.OnResetButtonPressed += ResetButtonPressed;

            timer = new Timer(10);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = false;

            _isStopWatchEnabled = false;
        }

        private void ToggleButtonPressed(object sender, EventArgs e)
        {
            if (!_isStopWatchEnabled)
            {
                _model.Start();
                timer.Enabled = true;

                _view.ApplyPauseButtonStyle();
                _view.EnableLapButton();
                _view.DisableResetButton();
            }
            else
            {
                _model.Stop();
                timer.Enabled = false;

                _view.ApplyStartButtonStyle();
                _view.DisableLapButton();
                _view.EnableResetButton();
            }

            _isStopWatchEnabled = !_isStopWatchEnabled;
        }

        private void LapButtonPressed(object sender, EventArgs e)
        {
            _model.Lap();
            _view.LapsChanged(_model.Laps);
        }

        private void ResetButtonPressed(object sender, EventArgs e)
        {
            if (_isStopWatchEnabled)
            {
                ToggleButtonPressed(this, null);
            }

            _model.Reset();

            OnTimedEvent(this, null);
            _view.ClearLaps();
            _view.DisableLapButton();
            _view.DisableResetButton();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            _view.ChangeTimeLabel(_model.Time);
        }
    }
}