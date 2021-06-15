using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Exercise1
{

    class Program
    {
        
    }
    class Square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number =>");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && a <= 10)
            {
                for (int i = 0; i < a; i++)
                {
                    a = a << 1; 
                    Console.Write("{0}", a);
                }
            }
            Console.ReadKey();
        }
    }

}
