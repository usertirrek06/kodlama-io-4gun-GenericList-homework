using System;

namespace SwitchCaseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            switch (a)
            {
                case 10:
                    Console.WriteLine(a);
                    break;
                case 1:
                    Console.WriteLine("Wrong");
                    break;
                default:
                    break;
            }
        }
    }
}
