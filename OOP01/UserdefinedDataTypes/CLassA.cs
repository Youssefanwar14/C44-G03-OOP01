using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.UserdefinedDataTypes
{
    public class CLassA
    {
            // what can i write inside this namespace?

            // 1- class
            // 2- struct
            // 3- interface
            // 4- enum

            // Access Modifiers allowed inside:
            // 1- public
            // 2- internal (Default)
       
            // What can I write inside this class?
            // 1- Attributes ==> member attributes
            // int x;
            // 2- Functions (Constructor,Getter,Setter,Method)
            // 3- Properties(full property,automatic property,indexer)
            // property => public int X { get; set; }
            // 4- Events

            // Access Modifiers allowed inside:
            //----------------------------------
            //1- private 
            private int X; // accessible only within this class
            //2- private protected 
            private protected int Z; // accessible only within this class and any nherited class in the same assembly
            //3- protected
            protected int Y; // accessible only within this class and any inherited class
            //4- internal
            internal int W; // accessible only within this assembly (Project)
            //5- protected internal
            protected internal int V; // accessible only within this assembly (Project) and any nherited class
            //6- public
            public int A; // accessible from anywhere
         
            public void SetX(int value)
            {

                X = value;
                Y = value;
                Z = value;
                W = value;
                V = value;

            }
        }
    }
