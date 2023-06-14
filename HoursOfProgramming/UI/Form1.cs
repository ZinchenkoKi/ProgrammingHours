using System;
using System.Windows.Forms;
using HoursOfProgramming.DomainModel;
using HoursOfProgramming.Presentation;
using HoursOfProgramming.UI;

namespace HoursOfProgramming
{
    public partial class Form1 : Form
    {
        TimeInFile timeInFile = new TimeInFile();
        TimeInApp timeInApp = new TimeInApp();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var hours = new Hours(timeInFile);
            hours.Get(label7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var startingTimer = new StartingTimer();
            startingTimer.Start(timer1, button1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var tick = new Stopwatch(timeInApp);
            tick.Update(label1, label2, label3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var closingApplication = new ClosingApplication(timeInFile, timeInApp);
            closingApplication.Close(timeInApp);
        }
    }
}