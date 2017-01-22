using System;

namespace StopWatch.Model
{
    public struct Lap
    {
        public readonly TimeSpan Time;
        public readonly TimeSpan Duration;

        public Lap(TimeSpan time, TimeSpan duration)
        {
            Time = time;
            Duration = duration;
        }
    }
}