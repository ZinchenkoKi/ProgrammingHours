using HoursOfProgramming.View;

namespace HoursOfProgramming.Model.Stopwatchs
{
    /// <summary>
    /// Запуускает секундомер.
    /// Изменяет текст кнопки Старт.
    /// </summary>
    public class Stopwatch
    {
        private IStopwatch _state;

        public Stopwatch(IStopwatch state)
        {
            _state = state; 
        }

        /// <summary>
        /// Запускает и останавливает секунодмер.
        /// 
        /// </summary>
        /// <param name="text"> Текст кнопки Старт </param>
        /// <param name="timerEnabled">Состояние таймера</param>
        /// <returns></returns>
        public IStopwatch Start()
        {
            _state.TimerEnabled = IsActive(_state.Start);
            if (_state.TimerEnabled)
            {
                _state.Start = "STOP";
                return _state;
            }
            _state.Start = "START";
            return _state;
        }

        /// <summary>
        /// Проверяет запущен таймер или нет.
        /// </summary>
        /// <param name="text"> Текст кнопки Старт </param>
        /// <returns>Возвращает bool состояние кнопки</returns>
        public bool IsActive(string text)
        {
            return text == "START";
        }
    }
}
