using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int length;

            //Console.WriteLine("Acest program va calcula aria unuei camere");
            Console.WriteLine("Enter width: ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter length: ");
            length = int.Parse(Console.ReadLine());

           /* int ariaCamerei = latime * lungime;
            Console.WriteLine("Aria camerei este " + ariaCamerei);*/

            if(width == length)
                Console.WriteLine("Width and Length are equal");

            else if (width < length)
                    Console.WriteLine("Width is smaller than length");
            else if (width > length)
                    Console.WriteLine("Width is greater than length");


        }
    }
}
