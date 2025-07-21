using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.UserdefinedDataTypes
{
    internal class ClassB : CLassA // ClassB inherits from ClassA
    {
        
        public ClassB()
        {
            Y = 10;
            V = 10; // protected internal is accessible here because ClassB is in the same assembly as ClassA
            
        }

    }
}
