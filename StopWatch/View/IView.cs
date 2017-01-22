using System;
using System.Collections.Generic;
using StopWatch.Model;

namespace StopWatch
{
    public interface IView
    {
        event EventHandler<EventArgs> OnToggleButtonPressed;
        event EventHandler<EventArgs> OnLapsButtonPressed;
        event EventHandler<EventArgs> OnResetButtonPressed;
        void ChangeTimeLabel(TimeSpan time);
        void LapsChanged(List<Lap> laps);

        void EnableResetButton();
        void DisableResetButton();
        void EnableLapButton();
        void DisableLapButton();
        void ApplyStartButtonStyle();
        void ApplyPauseButtonStyle();
        void ClearLaps();
    }
}