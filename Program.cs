﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Choice()
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Program.gameOver = true;
            }
            else if (key.Key == ConsoleKey.A)
            {

            }
            else if (key.Key == ConsoleKey.D)
            {

            }
        }
    }
}
