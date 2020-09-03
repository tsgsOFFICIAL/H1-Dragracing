using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Dragracing
{
    class Program
    {
        static void Main()
        {
            DrawCar(ConsoleColor.Red, "o_o", 99, true);
            DrawCar(ConsoleColor.Green, "^_^", 15, true);
            Console.ReadKey(true);
        }

        /// <summary>
        /// This method draws a car, with the specified parameters
        /// </summary>
        /// <param name="carColor">The color is taken from the System.ConsoleColor enum</param>
        /// <param name="facialExpresseion">The facial expression string of the character, use 3 characters</param>
        /// <param name="carNumber">The number on the side of the car, max 2 digits</param>
        /// <param name="drawRoad">The number on the side of the car, max 2 digits</param>
        static void DrawCar(ConsoleColor carColor, string facialExpresseion, int carNumber, bool drawRoad)
        {
            string[] Car = new string[]
            {
                @"                ___",
                @$"               ({facialExpresseion}\   \",
                @"      _________[___]__/_>______",
                @$"     /  ____ \ ({carNumber.ToString().PadLeft(2,'0')})   |  ____  \",
                @"    =\_/ __ \_\_______|_/ __ \__D",
                @"        (__)             (__)    ",
            };

            Console.ForegroundColor = carColor;
            foreach (string line in Car)
            {
                Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (drawRoad)
            {
                DrawRoad();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This method draws the road
        /// </summary>
        static void DrawRoad()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
        }
    }
}
