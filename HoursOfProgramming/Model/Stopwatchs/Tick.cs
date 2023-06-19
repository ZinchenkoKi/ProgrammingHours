using HoursOfProgramming.View;

namespace HoursOfProgramming.Model.Stopwatchs
{
    /// <summary>
    /// Проиводит увеличение на одну секунду
    /// </summary>
    public class Tick : ITick
    {
        private ITimeData _timeInApp;

        public Tick(ITimeData timeInApp) 
        {
            _timeInApp = timeInApp;
        }

        /// <summary>
        /// Увеличивает показатель _timeInApp.Seconds на 1
        /// </summary>
        /// <returns>Возврощает TimeInApp</returns>
        public ITimeData Update()
        {
            _timeInApp.Seconds++;
            return _timeInApp;
        }
    }
}
