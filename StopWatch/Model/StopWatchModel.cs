using System;
using System.Collections.Generic;

namespace StopWatch.Model
{
    public class StopWatchModel
    {
        public TimeSpan Time
        {
            get
            {
                if (_stopWatchRunning)
                {
                    return _countedTime + (DateTime.Now - _startTime);
                }

                return _countedTime;
            }
        }

        /// <summary>
        /// List of Laps
        /// </summary>
        public List<Lap> Laps;
        
        private bool _stopWatchRunning;
        private TimeSpan _countedTime;
        private DateTime _startTime;

        public StopWatchModel()
        {
            _stopWatchRunning = false;
            Laps = new List<Lap>();
        }

        public void Start()
        {
            if (_stopWatchRunning)
                return;

            _stopWatchRunning = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_stopWatchRunning)
                return;

            _stopWatchRunning = false;
            _countedTime += DateTime.Now - _startTime;
        }

        public void Lap()
        {
            TimeSpan duration;

            if (Laps.Count == 0) // If there is only one lap, then the duration is as long as the lap itself
            {
                duration = Time;
            }
            else
            {
                duration = Time - Laps[Laps.Count - 1].Time;
            }

            Laps.Add(new Lap(Time, duration));
        }

        public void Reset()
        {
            _stopWatchRunning = false;
            _countedTime = TimeSpan.Zero;
            Laps.Clear();
        }
    }
}