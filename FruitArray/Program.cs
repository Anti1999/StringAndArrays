using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja sööb

            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };

            //Console.WriteLine(fruit[0]);
            Random rnd = new Random();
            int usernumber = rnd.Next(0, fruit.Length);

            //Console.WriteLine("Enter a number fron 0 to 4");
            //int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Today you will have {fruit[usernumber]} ");
        }
    }
}
