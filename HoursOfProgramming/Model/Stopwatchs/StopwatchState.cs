namespace HoursOfProgramming.Model.Stopwatchs
{
    /// <summary>
    /// Содержит состяние таймера и название кнопки.
    /// </summary>
    public class StopwatchState
    {
        public string Text { get; set; }
        public bool TimerEnabled { get; set; }
    }
}
