using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.View
{
    public interface IRecount
    {
        public ITimeData Recalculate(ITimeData timeInApp, ITimeData timeInFile);
    }
}
