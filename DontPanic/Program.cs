using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic" 0-iga
            //programm asendab kõik 'a' tähed lauses "Don't panic" 4-ga

            string DontP = "Don't Panic!";

            for (int i = 0; i < DontP.Length; i++) ;

               

                DontP = DontP.Replace('o', '0');
            DontP = DontP.Replace('a', '4');

            Console.WriteLine(DontP);
        }
    }
}
