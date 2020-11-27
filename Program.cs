using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsKeyword
{   
        class Program
    {
        static void Main(string[] args)
        {

            // As Keyword convert one to another
            // It converts only reference type or nullable 
            object Value1 = 123;
            string Data1 = Value1 as string;

            // Is Keyword check conversion is compatible or not
            // It return true/false
            int Value3 = 874;
            Boolean Result = Value3 is string;
        }
    }
}
