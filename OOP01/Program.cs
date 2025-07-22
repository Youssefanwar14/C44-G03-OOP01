using OOP01.Enums;
using OOP01.UserdefinedDataTypes;
using System.ComponentModel.Design;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Console.WriteLine("Days of the Week: ");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //} 
            #endregion

            #region Question 2
            //Console.WriteLine("Please enter Season name: ");
            //string SeasonName = Console.ReadLine();
            //object seasonobj;
            //bool isparsed = Enum.TryParse(typeof(Season), SeasonName,true, out seasonobj);

            //if (isparsed)
            //{
            //    if ((Season)seasonobj == Season.Spring)
            //    {
            //        Console.WriteLine("Month range: Mar => May");
            //    }
            //    else if ((Season)seasonobj == Season.Winter)
            //    {
            //        Console.WriteLine("Month range: Dec => Feb");
            //    }
            //    else if ((Season)seasonobj == Season.Summer)
            //    {
            //        Console.WriteLine("Month range: Jun => Aug");
            //    }
            //    else if ((Season)seasonobj == Season.Autumn)
            //    {
            //        Console.WriteLine("Month range: Sep => Nov");
            //    }

            //}
            //else
            //    Console.WriteLine("Invalid Input.");

            #endregion

            #region Question 3
            //Permissions userPermissions = (Permissions) 10;
            //Console.WriteLine(userPermissions);
            //userPermissions = (Permissions)10 ^ Permissions.Read | Permissions.Write;
            //Console.WriteLine(userPermissions);
            #endregion

            #region Question 4
            //Console.WriteLine("PLease enter a color: ");
            //string colorName = Console.ReadLine();
            //object colorObj;
            //bool isprimarycolor = Enum.TryParse(typeof(Colors), colorName, true, out colorObj);

            //if (isprimarycolor)
            //{
            //    if ((Colors)colorObj == Colors.red || (Colors)colorObj == Colors.green || (Colors)colorObj == Colors.blue)
            //    {
            //        Console.WriteLine("The color is Primary.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The color is not Primary.");

            //    }
            //}
            //else
            //    Console.WriteLine("Invalid Input.");
            
            #endregion
        }
    }
}
