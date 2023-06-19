using HoursOfProgramming.View;

namespace HoursOfProgramming.Model.Data
{
    /// <summary>
    /// Содержит состяние таймера и название кнопки.
    /// </summary>
    public class StopwatchState : IStopwatch
    {
        public string Start { get; set; }
        public bool TimerEnabled { get; set; }
    }
}
