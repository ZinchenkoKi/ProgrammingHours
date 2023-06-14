using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoursOfProgramming.TimerData;

namespace HoursOfProgramming.ChangingFile
{
    public class RecalculatingTimeFile
    {
        public TimeInFile Recalculating(TimeInFile timeInFile)
        {
            if (timeInFile.SecondsInFile > 59)
            {
                timeInFile.MinutesInFile += timeInFile.SecondsInFile / 60;
                timeInFile.SecondsInFile = timeInFile.SecondsInFile % 60;
            }
            else if (timeInFile.MinutesInFile > 59)
            {
                timeInFile.HoursInFile += timeInFile.MinutesInFile / 60;
                timeInFile.MinutesInFile = timeInFile.MinutesInFile % 60;
            }
            return timeInFile;
        }
    }
}
