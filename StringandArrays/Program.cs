using System;

namespace StringandArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada kasutajal eesnime
            //programm kuvab eesnime pikkust

            Console.WriteLine("Palun sisestage eesnimi");
            string firstName = Console.ReadLine();

            //int firstNameLength = firstName.Length;

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
        }
    }
}
