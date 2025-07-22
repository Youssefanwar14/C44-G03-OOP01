using OOP01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.UserdefinedDataTypes
{
    public class Student
    {
        public int Id{ get; set; }
        public string? Name { get; set; }

        public Gender Gender { get; set; }

        public Branch Branch { get; set; }
        public Grade Grade { get; set; }
    }
}
