using HoursOfProgramming.DomainModel;
using HoursOfProgramming.Presentation;
using System.Windows.Forms;

namespace HoursOfProgramming.UI
{
    public class Stopwatch
    {
        private TimeInApp _timeInApp;

        public Stopwatch(TimeInApp timeInApp)
        {
            _timeInApp = timeInApp;
        }

        public TimeInApp Update(Label labelOne, Label labelTwo, Label labelThree)
        {
            var condition = new ConditionLable(_timeInApp);
            var tick = new Tick(_timeInApp);
            _timeInApp = tick.Update();
            condition.Update(labelOne, labelTwo, labelThree);
            return _timeInApp;
        }
    }
}
