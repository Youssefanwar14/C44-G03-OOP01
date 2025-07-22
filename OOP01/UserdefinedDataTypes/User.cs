using OOP01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.UserdefinedDataTypes
{
    internal class User
    {
        public int Id { get; set; }
        public Permission Permission { get; set; }
        //public bool[] Permissions { get; set; } = new bool[4];
    }
}
