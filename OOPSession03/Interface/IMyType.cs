using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession03.Interface
{
    internal interface IMyType
    {
        //default access modifier inside interface [public]
        // private is not allowed inside interface except one case

        // 1. signature for property
        public int Age {  get; set; }  // but inside class or struct Automatic property

        // 2. signature for method
        public void Myfunc();
        
        // 3. Default implemented method
        private void Print()
        {
            Console.WriteLine("Default Implemented Method");

        }

    }
}
