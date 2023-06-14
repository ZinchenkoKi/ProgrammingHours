using System.Windows.Forms;
using HoursOfProgramming.UI;

namespace HoursOfProgramming.Presentation
{
    public class StartingTimer
    {
        public void Start(Timer timer, Button button)
        {
            var changingText = new Start();

            changingText.Activation(button);
            changingText.Activation(timer, button);
        }

    }
}
