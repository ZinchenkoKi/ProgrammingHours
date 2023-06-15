using HoursOfProgramming.Model;

namespace HoursOfProgramming.View
{
    internal interface ITime
    {
        public string Hours { get; set; }
        public string Minutes { get; set; }
        public string Seconds { get; set; }
    }
}
