using HoursOfProgramming.View;

namespace HoursOfProgramming.Model
{
    /// <summary>
    /// Проверяет корректность времени
    /// </summary>
    public class CorrectData : ICorrect
    {
        public bool IsCorrect(int values)
        {
            return values > 59;
        }
    }
}
