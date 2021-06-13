using System;

namespace SwapNosWithoutTempVar
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 25;
            Console.WriteLine("value of a is : "+a);
            Console.WriteLine("value of b is : " + b);
            Console.ReadLine();
            Console.WriteLine("Press Any key to continue");
            Console.ReadKey();

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(" New value of a is : " + a);
            Console.WriteLine(" New value of b is : " + b);
            Console.ReadLine();

        }
    }
}
