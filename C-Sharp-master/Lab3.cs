using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
     class Lab3
    {
        class MyClass
        {
            private int a;
            public void setValue(int a)
            {
                this.a = a;
            }
        }
        class BaseClass
        {
            protected int a,b;

        }
        class DerivedClass: BaseClass
        {
            public void SetValue(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class BaseClass2
        {
            public int a,b;

        }
        class DerivedClas2 : BaseClass2
        {
            public void SetValue(int a , int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class MyClass2
        {
            private int a,b;
            public void SetValue(int a , int b)
            {
                this.a = a;
                this.b = b;
            }
            public int GetSum()
            {
                return a + b;
            }
        }
        class MyClass3
        {
            private void PrintHello()
            {
                Console.WriteLine("Hello World...");
            }
            public void AccessPublic()
            {
                this.PrintHello();
            }
        }
        class BaseClass3
        {
            protected void PrintName()
            {
                Console.WriteLine("My name is Yashika");
            }
        }
        class DerivedClass3 : BaseClass3
        {
            public void Access()
            {
                this.PrintName();
            }
        }
        class MyClass4
        {
            int a, b;
            internal MyClass4(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        public void Program1()
        {
            MyClass c = new MyClass();
            c.setValue(1);
        }
        public void Program4()
        {
            DerivedClass d = new DerivedClass();
            d.SetValue(1,2);
        }
        public void Program6()
        {
            DerivedClas2 d = new DerivedClas2();
            d.SetValue(5, 6);
        }
        public void Program7()
        {
            MyClass2 c = new MyClass2();
            c.SetValue(1,2);
            Console.WriteLine(c.GetSum());
        }
        public void Program8()
        {
            MyClass3 c = new MyClass3();
            c.AccessPublic();
        }
        public void Program9()
        {
            DerivedClass3 d = new DerivedClass3();
            d.Access();
        }
    }
}
