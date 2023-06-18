using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.View
{
    public interface IRecount
    {
        public TimeInFile Recalculate(TimeInApp timeInApp, TimeInFile timeInFile);
    }
}
