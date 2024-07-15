using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession03.Binding
{
    internal class FullTimeEmployee :Employee
    {
        public decimal Salary { get; set; }
        public new void MyFunc01()
        {
            Console.WriteLine("I am FullTime Employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"Id : {Id}\n Name: {Name}\n Age: {Age}\n Salary: {Salary:c}");
        }
    }
}
