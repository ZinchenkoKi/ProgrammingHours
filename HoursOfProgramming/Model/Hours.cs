
using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.Model
{
    public class Hours
    {
        private TimeInFile _timeInFile;

        public Hours(TimeInFile timeInFile)
        {
            _timeInFile = timeInFile;
        }

        public TimeInFile Get()
        {
            var file = new DataTime(_timeInFile);
            _timeInFile = file.Reading();
            return _timeInFile;
        }
    }
}
