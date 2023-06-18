using HoursOfProgramming.View;

namespace HoursOfProgramming.Model
{
    public class CorrectData : ICorrect
    {
        public bool IsCorrect(int values)
        {
            return values > 59;
        }
    }
}
