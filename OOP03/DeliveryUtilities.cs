using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================");
        }

        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine("Delivery Center");
            PrintSeparator();
        }
    }
}
