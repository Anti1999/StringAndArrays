﻿using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //progrmm kuvab lauset "Hello World" tagurpidi

            

            string HelloWorld = "Hello World";

            for (int i = HelloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(HelloWorld[i]);
            }
        }
    }
}
