using System.Windows.Forms;
using HoursOfProgramming.LogicalPart;
using HoursOfProgramming.TimerData;

namespace HoursOfProgramming.VsualPart
{
    public class StopwatchTick
    {
        UpdateLable updateLable = new UpdateLable();
        UpdatingIndicators updatingIndicators = new UpdatingIndicators();

        public TimeInApp Tick(TimeInApp timeInApp, Label labelOne, Label labelTwo, Label labelThree)
        {
            updatingIndicators.Update(timeInApp);
            updateLable.Update(timeInApp, labelOne, labelTwo, labelThree);
            return timeInApp;
        }
    }
}
