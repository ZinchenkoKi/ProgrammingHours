using System;
using System.Windows.Forms;
using HoursOfProgramming.View;
using HoursOfProgramming.Model;
using HoursOfProgramming.Presenter;
using HoursOfProgramming.Model.Data;
using HoursOfProgramming.Model.Stopwatchs;
using HoursOfProgramming.Model.ExitApplication;

namespace HoursOfProgramming
{
    public partial class Form1 : Form, IStopwatch, ITime, IAllHours
    {
        TimeInFile timeInFile = new TimeInFile();
        TimeInApp timeInApp = new TimeInApp();

        public string Start
        {
            get => ButtonStart.Text;
            set => ButtonStart.Text = value;
        }

        public bool TimerEnabled
        {
            get => Timer.Enabled;
            set => Timer.Enabled = value;
        }

        public string Hours
        {
            get => HoursLabel.Text;
            set => HoursLabel.Text = value;
        }

        public string Minutes
        {
            get => MinutesLabel.Text;
            set => MinutesLabel.Text = value;
        }

        public string Seconds
        {
            get => SecondsLabel.Text;
            set => SecondsLabel.Text = value;
        }

        public string MaximumHours 
        { 
            set => AllHours.Text = value;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            var hours = new Hours(timeInFile);
            timeInFile = hours.Get();
            MaximumHours = timeInFile.HoursInFile.ToString();
        }

        private void StopwatchStart(object sender, EventArgs e)
        {
            var state = new StopwatchState();
            var stopwatcOn = new StopwatchOn(this);
            state = stopwatcOn.Start();
            Start = state.Text;
            TimerEnabled = state.TimerEnabled;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var tick = new StopwatchTick(timeInApp);
            timeInApp = tick.Update();
            Hours = timeInApp.Hours.ToString();
            Minutes = timeInApp.Minutes.ToString();
            Seconds = timeInApp.Seconds.ToString();
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            var closingApplication = new ExitingApplication(timeInFile, timeInApp);
            closingApplication.GoOut();
        }
    }
}