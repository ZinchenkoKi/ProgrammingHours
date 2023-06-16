namespace HoursOfProgramming.Model.Stopwatchs
{
    /// <summary>
    /// Производит запуск и остановку секундомера.
    /// Изменяет текст кнопки Старт.
    /// </summary>
    public class Stopwatch
    {
        private StopwatchState _state;

        public Stopwatch()
        {
            _state = new StopwatchState();
        }

        /// <summary>
        /// Запускает и останавливает секунодмер.
        /// Возвращает класс StopwatchState с именем кнопки состоянием таймера.
        /// </summary>
        /// <param name="text"> Текст кнопки Старт </param>
        /// <param name="timerEnabled">Состояние таймера</param>
        /// <returns></returns>
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

        /// <summary>
        /// Проверяет запущен таймер или нет.
        /// </summary>
        /// <param name="text"> Текст кнопки Старт </param>
        /// <returns></returns>
        private bool IsActive(string text)
        {
            return text == "START";
        }
    }
}
