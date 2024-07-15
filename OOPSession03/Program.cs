using OOPSession03.Binding;
using OOPSession03.Interface;
using OOPSession03.Overriding;
using System.Diagnostics.CodeAnalysis;

namespace OOPSession03
{
    internal class Program
    {
        #region Overloading
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static int sum(int x, int y, int z, int f)
        {
            return x + y + z + f;
        } 
        #endregion

        public static void ProcessEmp(Employee emp)
        {
            if(emp != null)
            {
                emp.MyFunc01();
                emp.MyFunc02();
            }
        }

        //overloading  xxxxx
        //public static void ProcessEmp(PartTimeEmployee fullTimeEmployee)
        //{
        //    if (fullTimeEmployee != null)
        //    {
        //        fullTimeEmployee.MyFunc01();
        //        fullTimeEmployee.MyFunc02();
        //    }
        //}

        static void Main(string[] args)
        {
            #region Overloading
            //int result = sum(3, 4);
            //Console.WriteLine(result);
            //result = sum(3, 4, 10);
            //Console.WriteLine(result);
            //result = sum(3, 4, 11);
            //Console.WriteLine(result);
            #endregion

            #region overriding
            //TypeA typeA = new TypeA(10);
            //typeA.Myfunc01();
            //typeA.Myfunc02();

            //TypeB typeB = new TypeB(5, 10);
            //typeB.A = 3;
            //typeB.B = 4;
            //typeB.Myfunc01(); // I am base
            //typeB.Myfunc02(); // A : 3

            //typeB.GetType();
            #endregion

            #region Binding
            //refernce from parent => object from child
            //TypeA refBase = new TypeB(10,3);

            //refBase.A = 3;  //valid
            ////refBase.B = 4;  //invalid

            ////overrided with "new" keyword
            //refBase.Myfunc01(); // I am Base [parent] static Binding

            ////overrided with "override" keyword
            //refBase.Myfunc02(); // B = 2  [override => child]  Dynamic Binding =>  based on the reference








            #endregion

            #region NOT Binding
            //TypeA typeA = new TypeB(10, 3); //Binding

            //TypeB typeB;
            //typeB = (TypeB)typeA;   // NOT Binding 
            //                        // this called Casting [Unsafe] 
            #endregion

            #region Busniss need of binding 
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "mahmoud",
            //    Age = 22,
            //    Salary = 54000
            //};

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 20,
            //    Name = "Ali",
            //    Age = 22,
            //    HourRate = 10

            //};

            //ProcessEmp(fullTimeEmployee);
            //ProcessEmp(partTimeEmployee);


            #endregion


            #region More Practice on Binding
            //// TypeA typeA2 = new TypeC(1, 2, 3);
            // TypeB typeB1 = new TypeC(10, 3 ,20);
            // typeB1.A = 1; //valid
            // typeB1.B = 10; //valid
            // typeB1.C = 20; //invalid

            // typeB1.Myfunc01(); // I am base [static biding]
            // typeB1.Myfunc02(); // [dynamic binding]  C = 3



            //TypeA typeA3 = new TypeE(1, 2, 3, 4, 5);

            //TypeB typeB3 = new TypeE(1, 2, 3, 4, 5);

            //TypeC typeC3 = new TypeE(1, 2, 3, 4, 5);

            //typeA3.Myfunc02(); //dynamic Binding
            //typeB3.Myfunc02(); //dynamic Binding
            //typeC3.Myfunc02(); //dynamic binding

            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //typeD.Myfunc02();






            #endregion

            #region Interface
            //IMyType myType = new MyType();
            //myType.Myfunc();
            // myType.print(); xxxxxx


            #endregion

        }

    } 
}
