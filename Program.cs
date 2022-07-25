using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> sayilar = new MyList<int>();

            sayilar.Add(3);
            
            sayilar.Remove(3);
            foreach (var item in sayilar.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
