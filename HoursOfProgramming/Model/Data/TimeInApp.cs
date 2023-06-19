using HoursOfProgramming.View;

namespace HoursOfProgramming.Model.Data
{
    /// <summary>
    /// Содержит показатели часов минут и секунд.
    /// </summary>
    public class TimeInApp : ITimeData
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
}
