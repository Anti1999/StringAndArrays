using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // //programm kuvab konsoolis mitu 'h', 'o' ja 'l' tähte on lauses "Hello World"

            string helloWorld = "Hello World";

            helloWorld = helloWorld.ToLower();

            int hcounter = 0;
            int ocounter = 0;
            int lcounter = 0;

            
            
            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                   hcounter++;
                }
                if (helloWorld[i] == 'o')
                {
                    ocounter++;
                }
                if (helloWorld[i] == 'l')
                {
                    lcounter++;
                }
            
            }
            Console.WriteLine(hcounter != 1 ? $"Hello Worldis on  {hcounter} 'h' tähte." : $"Hello worldis on  {hcounter} 'h' täht.");
           
            if (hcounter != 1)
            {
                Console.WriteLine($"Hello Worldis on  {hcounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Hello worldis on  {hcounter} 'h' täht.");
            }

            if (ocounter != 1)
            {
                Console.WriteLine($"Hello Worldis on  {ocounter} 'o' tähte.");

            }
            else
            {
                Console.WriteLine($"Hello worldis on  {ocounter} 'o' täht.");
            }
            if (lcounter != 1)
            {
                Console.WriteLine($"Hello Worldis on  {lcounter} 'l' tähte.");

            }
            else
            {
                Console.WriteLine($"Hello worldis on  {lcounter} 'l' täht.");
            }

        }
    }
}
