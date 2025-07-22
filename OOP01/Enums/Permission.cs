using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.Enums
{
    [Flags]
     public enum Permission : byte // Using Byte to save memory [8 BITS ONLY]

    {
        Read = 1,
        Write = 2,
        Execute = 4,
        Delete = 8
        
        
    }
}
