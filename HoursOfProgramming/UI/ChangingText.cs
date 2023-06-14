using System.Windows.Forms;

namespace HoursOfProgramming.UI
{
    public class Start
    {
        public void Activation(Button button)
        {
            if (IsActive(button))
            {
                button.Text = "STOP";
            }
            else
            {
                button.Text = "START";
            }
        }


        public void Activation(Timer timer, Button button)
        {
            if (IsActive(button))
            {
                timer.Enabled = false;
            }
            else
            {
                timer.Enabled = true;
            }
        }

        private bool IsActive(Button button)
        {
            return button.Text == "START";
        }
    }
}
