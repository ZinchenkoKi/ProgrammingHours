namespace HoursOfProgramming.Model.Stopwatchs
{
    public class Stopwatch
    {
        private StopwatchState _state;

        public Stopwatch()
        {
            _state = new StopwatchState();
        }

        public StopwatchState Start(string text, bool timerEnabled)
        {
            if (IsActive(text))
            {
                _state.TimerEnabled = true;
                _state.Text = "STOP";
                return _state;
            }
            _state.TimerEnabled = false;
            _state.Text = "START";
            return _state;
        }

        private bool IsActive(string text)
        {
            return text == "START";
        }
    }
}
