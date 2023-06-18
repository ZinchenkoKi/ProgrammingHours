using System;
using System.Windows.Forms;
using HoursOfProgramming.View;
using HoursOfProgramming.Model;
using HoursOfProgramming.Presenter;
using HoursOfProgramming.Model.Data;
using HoursOfProgramming.Model.Stopwatchs;

namespace HoursOfProgramming
{
    public partial class Form1 : Form, IStopwatch, ITime, IAllHours
    {
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
            var path = new FilePath();
            var read = new Read(path);
            var launch = new StopwatchLaunch(read);
            MaximumHours = launch.Start();
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
            var tick = new Tick(timeInApp);
            var correct = new CorrectData();
            var stopwatch = new StopwatchTick(tick, correct);
            timeInApp = stopwatch.Tick();
            Hours = timeInApp.Hours.ToString();
            Minutes = timeInApp.Minutes.ToString();
            Seconds = timeInApp.Seconds.ToString();
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            var correct = new CorrectData();
            var path = new FilePath();
            var read = new Read(path);
            var record = new Record(path);
            var recount = new Recount(correct);
            var stopwatch = new StopwatchClose(timeInApp, read, record, recount);
            stopwatch.Close();
        }
    }
}