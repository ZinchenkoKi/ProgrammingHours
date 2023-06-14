using System.Windows.Forms;
using HoursOfProgramming.TimerData;

namespace HoursOfProgramming
{
    public class UpdateLable
    {
        public void Update(TimeInApp timeInApp, Label labelOne, Label labelTwo, Label labelThree)
        {
            CheckingUnits(timeInApp.HoursInApp, labelOne);
            CheckingUnits(timeInApp.MinutesInApp, labelTwo);
            CheckingUnits(timeInApp.SecondsInApp, labelThree);
        }

        private void CheckingUnits(int values, Label label)
        {
            if (values > 9)
            {
                label.Text = values.ToString();
            }
            else
            {
                label.Text = $"0{values.ToString()}";
            }
        }
    }
}
