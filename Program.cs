using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
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
            Console.ForegroundColor = ConsoleColor.White;
            ShowWindow(GetConsoleWindow(), MAXIMIZE); //Maximise the console

            Race sundayRace = new Race(); //Create and initialise a new Race

            while (AddRacers(sundayRace))
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (sundayRace.Racers.Count > 0)
            {
                foreach (Racer racer in sundayRace.Racers)
                {
                    DrawCar(racer.Car.Color, racer.Face, racer.Number, true);
                }
            }
            else
            {
                Console.WriteLine("You don't have any racers to compete...");
            }

            Console.ReadKey(true);
        }

        private static bool AddRacers(Race race)
        {
            string[] _faceNames = Enum.GetNames(typeof(Racer.Faces));
            string[] _colors = Enum.GetNames(typeof(ConsoleColor));
            string[] _faces = new string[] { "^_^", "~_~", "o_o", "*_*", "$_$", "o_O", "-_-" };
            string name;
            byte age;
            byte number;
            Racer.Faces face;
            ConsoleColor color;
            Car.Engines engine;

            Console.Clear();

            Console.WriteLine("Current racers: ");

            if (race.Racers.Count > 0)
            {
                foreach (Racer racer in race.Racers)
                {
                    Console.WriteLine(racer.Name);
                }
            }
            else
            {
                Console.WriteLine("none");
            }

            Console.WriteLine("\nAdd more? (Y/N)");

            while (true)
            {
                switch (Convert.ToChar(Console.ReadKey(true).KeyChar.ToString().ToLower()))
                {
                    case 'y':
                        Console.Write("\nRacer name: ");
                        name = Console.ReadLine();

                        Console.Write("\nRacer age: ");
                        try
                        {
                            age = byte.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Not a valid age");
                            Thread.Sleep(750);
                            return true;
                        }

                        Console.Write("\nRacer number: ");
                        try
                        {
                            number = byte.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Not a valid number");
                            Thread.Sleep(750);
                            return true;
                        }

                        Console.WriteLine("\nPick a face for your driver: ");
                        int iterator = 0;
                        foreach (int _faceIndex in Enum.GetValues(typeof(Racer.Faces)))
                        {
                            Console.WriteLine($"\n({_faceIndex}) {_faceNames[iterator],-8} {_faces[iterator],4}");
                            iterator++;
                        }

                        switch (Console.ReadKey(true).KeyChar)
                        {
                            case '0':
                                face = 0;
                                Console.WriteLine(face);
                                break;
                            case '1':
                                break;
                            case '2':
                                break;
                            case '3':
                                break;
                            case '4':
                                break;
                            case '5':
                                break;
                            case '6':
                                break;
                        }

                        iterator = 0;
                        foreach (int index in Enum.GetValues(typeof(ConsoleColor)))
                        {
                            Console.ForegroundColor = (ConsoleColor)index;
                            Console.WriteLine($"\n({index}) {_colors[iterator]}");
                            iterator++;
                        }
                        Console.ReadKey(true);
                        break;
                    case 'n':
                        return false;
                }
                return true;
            }
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
