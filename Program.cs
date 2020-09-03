using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Dragracing
{
    class Program
    {
        #region Magic from https://www.c-sharpcorner.com/code/448/code-to-auto-maximize-console-application-according-to-screen-width-in-c-sharp.aspx
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        #endregion
        static void Main()
        {
            ShowWindow(GetConsoleWindow(), MAXIMIZE);

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
            Console.ForegroundColor = carColor;
            string[] Car = new string[]
            {
                @"                ___",
                @$"               ({facialExpresseion}\   \",
                @"      _________[___]__/_>______",
                @$"     /  ____ \ ({carNumber.ToString().PadLeft(2,'0')})   |  ____  \",
                @"    =\_/ __ \_\_______|_/ __ \__D",
                @"        (__)             (__)    ",
            };

            foreach (string line in Car)
            {
                Console.WriteLine(line);
            }

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
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
        }
    }
}
