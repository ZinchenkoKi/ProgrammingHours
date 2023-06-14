using System.Windows.Forms;
using HoursOfProgramming.VsualPart;

namespace HoursOfProgramming.LogicalPart
{
    public class StartingTimer
    {
        public void Start(Timer timer, Button button)
        {
            ChangingText changingText = new ChangingText();

            changingText.ChangingButtonText(button);
            CheckingForActivity(timer, button);
        }

        private void CheckingForActivity(Timer timer, Button button)
        {

            if (button.Text == "START")
            {
                timer.Enabled = false;
            }
            else
            {
                timer.Enabled = true;
            }
        }
    }
}
