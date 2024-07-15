using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession03.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        
        public new void MyFunc01()
        {
            Console.WriteLine("I am PartTime Employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"Id : {Id}\n Name: {Name}\n Age: {Age}\nHourRate: {HourRate}");
        }



    }
}
