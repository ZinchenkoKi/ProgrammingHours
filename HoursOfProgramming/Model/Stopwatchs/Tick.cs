using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.Model.Stopwatchs
{
    public class Tick
    {
        private TimeInApp _timeInApp;

        public Tick(TimeInApp timeInApp)
        {
            _timeInApp = timeInApp;
        }

        /// <summary>
        /// Обновляет время каждую секунду.
        /// </summary>
        /// <returns> Возвращает обновленный экземпляр класса TimeInApp </returns>
        public TimeInApp Update()
        {
            _timeInApp.Seconds++;
            if (IsCorrect(_timeInApp.Seconds))
            {
                _timeInApp.Minutes++;
                _timeInApp.Seconds = 0;
            }
            if (IsCorrect(_timeInApp.Minutes))
            {
                _timeInApp.Hours++;
                _timeInApp.Minutes = 0;
            }
            return _timeInApp;
        }

        /// <summary>
        /// Проверяет корректность записи времени.
        /// </summary>
        /// <param name="values"> Показатель времени </param>
        /// <returns></returns>
        private bool IsCorrect(int values)
        {
            return values > 59;
        }
    }
}
