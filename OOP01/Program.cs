using OOP01.Enums;
using OOP01.UserdefinedDataTypes;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Console.WriteLine("Days of the Week: ");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            } 
            #endregion
        }
    }
}
