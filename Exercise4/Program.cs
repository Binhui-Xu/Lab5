using System;

namespace Exercise4
{
    class A
    {
        static int n = 1;
        public void f()
        {
            n++;
        }
        public void report()
        {
            Console.WriteLine(n.ToString());
        }
    }
    class MainClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            A x = new A(), y = new A();
            x.f();
            x.report();
            y.f();
            y.report();
        }
    }
}
