using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession03.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }

        public void MyFunc01()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void MyFunc02()
        {
            Console.WriteLine($"Id : {Id}\n Name: {Name}\n Age: {Age}");
        } 
    }
}
