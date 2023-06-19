using HoursOfProgramming.View;
namespace HoursOfProgramming.Model.Data
{
    /// <summary>
    /// Содержит показатели часов минут и секунд считанных из файла.
    /// </summary>
    public class TimeInFile :ITimeData
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
}
