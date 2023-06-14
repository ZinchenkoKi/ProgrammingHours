using System.Windows.Forms;
using HoursOfProgramming.DomainModel;

namespace HoursOfProgramming.UI
{
    public class ConditionLable
    {
        private TimeInApp _timeInApp;

        public ConditionLable(TimeInApp timeInApp)
        {
            _timeInApp = timeInApp;
        }

        public void Update(Label labelOne, Label labelTwo, Label labelThree)
        {
            Overwrite(_timeInApp.Hours, labelOne);
            Overwrite(_timeInApp.Minutes, labelTwo);
            Overwrite(_timeInApp.Seconds, labelThree);
        }

        private void Overwrite(int values, Label label)
        {
            if (IsNumeral(values))
            {
                label.Text = values.ToString();
            }
            else
            {
                label.Text = $"0{values.ToString()}";
            }
        }

        private bool IsNumeral(int values)
        {
            return values > 9;
        }
    }
}
