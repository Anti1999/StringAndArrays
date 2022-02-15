using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada kasutajal ees-ja perkonnanimi
            //programm kuvab mitu 'a' tähte on ees- ja perekonnanimes kokku


            Console.WriteLine("Palun sisestage eesnimi");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Palun sisestage perekonnanimi");
            string lastName = Console.ReadLine().ToLower();
            string fullName = ($"{firstName}{lastName}".ToLower());
            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }

            }
                

            if (aCounter !=1)
            {
            Console.WriteLine($"Sinu eesnimes on {aCounter} 'a' tähte.");

            }
            else
            {
            Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähts.");
            }


            
        }
    } 
}