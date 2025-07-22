using OOP01.Enums;
using OOP01.UserdefinedDataTypes;
using System.Xml.Linq;
namespace OOP01
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Enum => Enumeration

            #region Example 1
            //Person person = new Person();

            //person.Id = 1;
            //person.Name = "Ahmed";
            //person.Gender = Gender.Male;

            //Console.WriteLine(person.Gender);

            //Grade grade = Grade.A;

            //if (grade == Grade.A)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else 
            //{
            //    Console.WriteLine("Good Luck Next time");

            ////}
            //Grade grade2 = new Grade();
            //Console.WriteLine(grade2);
            #endregion

            #region Example 2
            //Student student = new Student();
            //bool isparseId;
            //int id;
            //Console.WriteLine("Please enter student data: ");
            //Console.WriteLine("please enter id: ");
            //do 
            //{
            //isparseId = int.TryParse(Console.ReadLine(), out  id);
            //    if (!isparseId)
            //        Console.WriteLine("Invaid Input");
            //} while (!isparseId);

            //student.Id = id;

            //Console.WriteLine("please enter Name: ");
            //student.Name = Console.ReadLine();

            //object gender;
            //Console.WriteLine("please enter Gender: ");
            //do
            //{
            //    isparseId = Enum.TryParse(typeof(Gender), Console.ReadLine(), out gender);
            //    if (!isparseId)
            //        Console.WriteLine("Invaid Input");
            //} while (!isparseId);
            //student.Gender = (Gender)gender;

            //object grade;
            //Console.WriteLine("please enter Grade: ");
            //do
            //{
            //    isparseId = Enum.TryParse(typeof(Grade), Console.ReadLine(),true ,out grade);
            //    if (!isparseId)
            //        Console.WriteLine("Invaid Input");
            //} while (!isparseId);
            //student.Grade = (Grade)grade;

            //object branch;
            //Console.WriteLine("please enter branch: ");
            //do
            //{
            //    isparseId = Enum.TryParse(typeof(Branch), Console.ReadLine(), out branch);
            //    if (!isparseId)
            //        Console.WriteLine("Invaid Input");

            //} while (!isparseId);
            //student.Branch = (Branch)branch;

            //Console.WriteLine($"Student Details => Id: {student.Id}, Name: {student.Name}, Gender: {student.Gender}, Branch: {student.Branch}, Grade: {student.Grade}");


            #endregion

            #region Example 3
            //User user = new User();
            //user.Id = 1;
            //user.Permissions[0] = true; // Read
            //user.Permissions[1] = false; // Write
            //user.Permissions[2] = true; // Execute
            //user.Permissions[3] = false; // Delete

            //user.Permission = (Permission)4;
            ////user.Permission = (Permission)10;
            //user.Permission = (Permission)15;
            //Console.WriteLine(user.Permission);
            //user.Permission = user.Permission ^ Permission.Read; 
            //Console.WriteLine(user.Permission);
            //// Note: if i want to add permission i can use XOR operator
            // it ruturns false if the permission already exists and true if it doesn't exist
            //user.Permission = user.Permission & Permission.Delete;
            //user.Permission = user.Permission | Permission.Delete; // this will check if delete permission exists or not
            //Console.WriteLine(user.Permission);

            #endregion

            #region Enum Methods
            //string branch = "Alex";
            //Branch branch1 = (Branch)Enum.Parse(typeof(Branch),branch);// This retuns object type

            // Label Names
            //string[] branchesNames = Enum.GetNames(typeof(Branch));
            //foreach (string name in branchesNames)
            //{
            //    Console.WriteLine(name);
            //}

            //// Label Values
            //Array values = Enum.GetValues(typeof(Branch));
            //foreach (int value in values)
            //{
            //    Console.WriteLine(value);
            //}

            bool isexists = Enum.IsDefined(typeof(Branch), 50);  // type of enum, value to check
            Console.WriteLine(isexists);
            #endregion
            #endregion
        }
    }
}
