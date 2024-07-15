using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession03.Interface
{
    internal class MyType : IMyType //implements
    {
        int salary;
        public int Age { get; set; } // Automatic Property
        //public int Age
        //{ 
        //    get  { return salary; }
        //    set  {  salary = value; }
        //}

        public void Myfunc()
        {
            Console.WriteLine("Hello Route!");
        }
    }
}
