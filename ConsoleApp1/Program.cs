using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ApplicationValue = 10;
            Console.Write(10);
            ApplicationValue = 20;
            Console.Write(10);
            Console.WriteLine("Hello World!");

            Console.WriteLine();
            if(ApplicationValue == 10)
            {
                Console.WriteLine("yes" + ApplicationValue);
            }




            //Array
            int [] arrayItems = new int[5];
            arrayItems[0] = 1;
            arrayItems[1] = 12;
            arrayItems[2] = 41;
            arrayItems[3] = 16;
            //For each
            foreach (int item in arrayItems)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
