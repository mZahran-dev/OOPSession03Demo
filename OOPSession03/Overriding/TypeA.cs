using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession03.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _a) 
        {
            A = _a;
        }

        public void Myfunc01()
        {
            Console.WriteLine("I am Base");
        }
        public virtual void Myfunc02()
        {
            Console.WriteLine($"type A : {A}");
        }
    }

    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        // Apply Function override using "new" keyword
        // static binded method
        // compiler will bind function call based on ref not object
        // happens on compilation time [early binding]
        public new void Myfunc01()
        {
            Console.WriteLine("I am Child");
        }

        // Apply Function override using "override" keyword => public virtual
        // dynamic binded method
        // compiler will bind function call based on object not ref
        // happens at Runtime [late binding]
        public override void Myfunc02()
        {
            base.Myfunc02();
        }

    }

    internal class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int _a, int _b, int _c): base(_a ,_b)
        {
            C = _c;
        }
        public new void Myfunc01()
        {
            Console.WriteLine("I am grand Child");
        }
        public override void Myfunc02()
        {
            Console.WriteLine($"C : {C}");
        }
    }


    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int _a, int _b, int _c,int _d) : base(_a, _b, _c)
        {
            D = _d;
        }
        public new void Myfunc01()
        {
            Console.WriteLine("I am grand Child");
        }

        //break the Chain and start anew Chain using new virtual
        public new virtual void Myfunc02()
        {
            Console.WriteLine($"D : {D}");
        }
    }



    internal class TypeE: TypeD
    {
        public int E { get; set; }
        public TypeE(int _a, int _b, int _c, int _d,int _E) : base(_a, _b, _c,_d)
        {
            E = _E;
        }
      
        //break the Chain and start anew Chain using new virtual
        public new virtual void Myfunc02()
        {
            Console.WriteLine($"D : {D}");
        }
    }
}
