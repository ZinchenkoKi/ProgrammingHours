using System.Windows.Forms;

namespace HoursOfProgramming.VsualPart
{
    public class ChangingText
    {
        public void ChangingButtonText(Button button)
        {
            if (button.Text == "START")
            {
                button.Text = "STOP";
            }
            else
            {
                button.Text = "START";
            }
        }
    }
}
