using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StopWatch.Model;

namespace StopWatch
{
    public partial class MainForm : Form, IView
    {
        public event EventHandler<EventArgs> OnToggleButtonPressed;
        public event EventHandler<EventArgs> OnLapsButtonPressed;
        public event EventHandler<EventArgs> OnResetButtonPressed;

        private readonly Color _buttonEnabledColor = Color.FromArgb(0, 73, 213, 255);
        private readonly Color _buttonDisabledColor = Color.Gainsboro;

        private DateTime? _lapButtonLastPress = DateTime.Now;

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTimeLabelCallback(TimeSpan time);

        public MainForm()
        {
            InitializeComponent();
        }

        public void ChangeTimeLabel(TimeSpan time)
        {
            //https://msdn.microsoft.com/en-us/library/ms171728.aspx

            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (hoursValueLabel.InvokeRequired || minutesValueLabel.InvokeRequired || secondsValueLabel.InvokeRequired || centisecondsValueLabel.InvokeRequired)
            {
                SetTimeLabelCallback d = new SetTimeLabelCallback(ChangeTimeLabel);

                try
                {
                    this.Invoke(d, new object[] { time });
                }
                catch (ObjectDisposedException)
                {
                    // Occurs when the Application is closed while the Timer is running. Ignore it
                }
            }
            else
            {
                hoursValueLabel.Text = $@"{time:%h}";
                minutesValueLabel.Text = $@"{time:mm}";
                secondsValueLabel.Text = $@"{time:ss}";
                centisecondsValueLabel.Text = $@"{time:ff}";
            }
        }

        public void LapsChanged(List<Lap> laps)
        {
            lapsView.Items.Clear();

            // Begin with last Lap
            for (int i = laps.Count; i > 0; i--)
            {
                var lap = laps[i-1];
                var item = new ListViewItem($"Lap {i}");

                item.SubItems.Add($"{lap.Duration:%h\\:mm\\:ss\\.ff}");
                item.SubItems.Add($"{lap.Time:%h\\:mm\\:ss\\.ff}");

                lapsView.Items.Add(item);
            }
        }

        public void ClearLaps()
        {
            lapsView.Items.Clear();
        }

        public void EnableResetButton()
        {
            resetButton.Click += resetButton_Click;
            resetLabel.Click += resetButton_Click;
            resetIcon.Click += resetButton_Click;

            resetLabel.ForeColor = _buttonEnabledColor;
            resetIcon.Image = Properties.Resources.reset_enabled;

            resetButton.Cursor = resetLabel.Cursor = resetIcon.Cursor = Cursors.Hand;
        }

        public void DisableResetButton()
        {
            resetButton.Click -= resetButton_Click;
            resetLabel.Click -= resetButton_Click;
            resetIcon.Click -= resetButton_Click;

            resetLabel.ForeColor = _buttonDisabledColor;
            resetIcon.Image = Properties.Resources.reset_disabled;

            resetButton.Cursor = resetLabel.Cursor = resetIcon.Cursor = Cursors.Default;
        }

        public void EnableLapButton()
        {
            lapButton.Click += lapButton_Click;
            lapLabel.Click += lapButton_Click;
            lapIcon.Click += lapButton_Click;

            lapLabel.ForeColor = _buttonEnabledColor;
            lapIcon.Image = Properties.Resources.flag_enabled;

            lapButton.Cursor = lapLabel.Cursor = lapIcon.Cursor = Cursors.Hand;
        }

        public void DisableLapButton()
        {
            lapButton.Click -= lapButton_Click;
            lapLabel.Click -= lapButton_Click;
            lapIcon.Click -= lapButton_Click;

            lapLabel.ForeColor = _buttonDisabledColor;
            lapIcon.Image = Properties.Resources.flag_disabled;

            lapButton.Cursor = lapLabel.Cursor = lapIcon.Cursor = Cursors.Default;
        }

        public void ApplyStartButtonStyle() => toggleButton.Image = Properties.Resources.play;

        public void ApplyPauseButtonStyle() => toggleButton.Image = Properties.Resources.pause;

        private void resetButton_Click(object sender, EventArgs e)
        {
            OnResetButtonPressed?.Invoke(this, null);
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            OnToggleButtonPressed?.Invoke(this, null);
        }

        private void htlLogo_Click(object sender, EventArgs e)
            => Process.Start(new ProcessStartInfo("https://www.htl-anichstrasse.tirol/"));

        private void htlLogo_MouseEnter(object sender, EventArgs e)
        {
            htlLogo.Image = Properties.Resources.htl_logo_color;
            htlLogo.Cursor = Cursors.Hand;
        }

        private void htlLogo_MouseLeave(object sender, EventArgs e)
        {
            htlLogo.Image = Properties.Resources.htl_logo_bw;
            htlLogo.Cursor = Cursors.Default;
        }

        private void lapButton_Click(object sender, EventArgs e)
        {
            if (DateTime.Now - _lapButtonLastPress > new TimeSpan(10)) // Avoid double-clicking
            {
                OnLapsButtonPressed?.Invoke(sender, e);
                _lapButtonLastPress = DateTime.Now;
            }
        }
    }
}

