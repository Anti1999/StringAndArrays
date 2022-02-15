using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada kasutajal ees-ja perkonnanimi
            //programm kontrollib andmete pikkust
            // programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi.


            Console.WriteLine ("Palun sisestage eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine ("Palun sisestage perekonnanimi");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            int lastNameLenght = lastName.Length;

            if (firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Teie perkonnanimi on pikem");
            }
            else if (firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Teie eesnimi on pikem");
            }
            else
            {
                Console.WriteLine("Teie eesnimes ja perekonnanimes on võrdne arv sümboleid");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
