
using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.Model
{
    /// <summary>
    /// Выводть количество часов.
    /// </summary>
    public class Hours
    {
        private TimeInFile _timeInFile;

        public Hours(TimeInFile timeInFile)
        {
            _timeInFile = timeInFile;
        }

        /// <summary>
        /// Метод считывает время из файла
        /// </summary>
        /// <returns>Возвращает экземпляр класса TimeInFile</returns>
        public TimeInFile Get()
        {
            var file = new DataTime(_timeInFile);
            _timeInFile = file.Reading();
            return _timeInFile;
        }
    }
}
