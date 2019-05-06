using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Array

    {
        private int winningNumber;
        
        List<int> column1 = new List<int>();
        List<int> column2 = new List<int>();
        List<int> column3 = new List<int>();

        public int ArrayOfNumbers()
        {
            int[] numbers = new int[38]
            {0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                31, 32, 33, 34, 35, 36};

            Random random = new Random();
            winningNumber = random.Next(numbers.Length);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------------");
            Console.WriteLine("Lucky Number: {0}", winningNumber);
            Console.WriteLine("---------------------");
            Console.ResetColor();
            return winningNumber;

        }
        //assigning colors to the random numbers 
        public void Colors()
        {
            if (winningNumber == 0 || winningNumber == 00)
            {
                Console.WriteLine("Green\n");
                Console.WriteLine("Congratulation! You have won the highest bet");

            }
            else if (winningNumber >= 1 && winningNumber <= 36)
            {
                int[] colors = new int[2] { 0, 1 };
                Random randomColor = new Random();
                var winningColor = randomColor.Next(colors.Length);
                if (winningColor == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Color: Red\n");
                    Console.ResetColor();
                }
                else if (winningColor == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Color: Black\n");
                    Console.ResetColor();
                }
            }
        }

        //Odd or Even 

        public void OddOrEven()
        {
            if (winningNumber % 2 == 0)
            {
                Console.WriteLine("Even Number\n");

            }
            else if (winningNumber % 2 != 0)
            {
                Console.WriteLine("Odd Number\n");
            }

        }
        //create a method Lows/Highs= LOW(1-18) HIGH(19-38)
        public void LowAndHigh()
        {
            if (winningNumber >= 1 && winningNumber <= 18)
            {
                Console.WriteLine("Low 1-18\n");
            }
            else if (winningNumber >= 19 && winningNumber <= 36)
            {
                Console.WriteLine("High 19-38\n");
            }
        }

        //creating dozens 
        public void Dozens()
        {
            if (winningNumber >= 1 && winningNumber <= 12)
            {
                Console.WriteLine("1st Dozen (1-12)\n");
            }
            else if (winningNumber >= 13 && winningNumber <= 24)
            {
                Console.WriteLine("2nd Dozen (13-24)\n");
            }
            else if (winningNumber >= 25 && winningNumber <= 36)
            {
                Console.WriteLine("3rd Dozen (25-36)\n");
            }
        }
        //create a method with columns
        public void Columns()
        {


            for (int x = 3; x < 37; x += 3)
            {
                column3.Add(x);
                if (winningNumber == x)
                {
                    Console.WriteLine("Column: 3\n");
                }
            }

            for (int x = 2; x < 36; x += 3)
            {
                column2.Add(x);
                if (winningNumber == x)
                {
                    Console.WriteLine("Column: 2\n");
                }

            }

            for (int x = 1; x < 35; x += 3)
            {
                column1.Add(x);
                if (winningNumber == x)
                {
                    Console.WriteLine("Column: 1\n");
                }
            }
        }
        //create a method Streets = create 12 streets with values. ex) st.1 has 1, 2, 3
        public void Streets()
        {

            if (column1.Contains(winningNumber))
            {
                int x = winningNumber - 1;
                int y = winningNumber - 2;

                Console.WriteLine("Street: {0}, {1}, {2}\n", winningNumber, x, y);
            }
            else if (column2.Contains(winningNumber))
            {
                int x = winningNumber + 1;
                int y = winningNumber - 1;

                Console.WriteLine("Street: {0}, {1}, {2}\n", winningNumber, x, y);
            }

            else if (column3.Contains(winningNumber))
            {
                int x = winningNumber + 1;
                int y = winningNumber + 2;

                Console.WriteLine("Street: {0}, {1}, {2}\n", winningNumber, x, y);
            }

        }
        //Creating double rows
        public void DoubleRowsForColumnOne()
        {
            int oneUp = winningNumber + 1;
            int twoUp = winningNumber + 2;
            int right = winningNumber + 3;
            int rightOneUp = right + 1;
            int rightTwoUp = right + 2;
            int left = winningNumber - 3;
            int leftOneUp = left + 1;
            int leftTwoUp = left + 2;

            if (winningNumber == 1)
            {
                Console.WriteLine($"Double Row: {winningNumber}, {oneUp}, {twoUp}, {right}, {rightOneUp}, {rightTwoUp}\n");
            }

            else if (winningNumber == 34)
            {
                Console.WriteLine($"Double Row: {winningNumber}, {oneUp}, {twoUp}, {left}, {leftOneUp}, {leftTwoUp}\n");
            }
            else if (column1.Contains(winningNumber) && winningNumber != 1 && winningNumber != 34)
            {
                Console.WriteLine($"Double Row: {winningNumber}, {oneUp}, {twoUp}, {right}, {rightOneUp}, {rightTwoUp}\nOR\n ");
                Console.WriteLine($"Double Row: {winningNumber}, {oneUp}, {twoUp},{left}, {leftOneUp}, {leftTwoUp}\n");
            }
        }
        public void DoubleRowsForColumnTwo()
        {
            int up = winningNumber + 1;
            int down = winningNumber - 1;
            int topRight = winningNumber + 4;
            int topLeft = winningNumber - 2;
            int right = winningNumber + 3;
            int left = winningNumber - 3;
            int bottomRight = winningNumber + 2;
            int bottomLeft = winningNumber - 4;

            if (winningNumber == 2)
            {

                Console.WriteLine($"Double Rows: {winningNumber}, {up}, {down}, {topRight}, {right}, {bottomRight}\n");

            }
            else if (winningNumber == 35)
            {

                Console.WriteLine($"Double Rows:{winningNumber}, {up}, {down}, {topLeft}, {left}, {bottomLeft}\n");

            }

            else if (column2.Contains(winningNumber) && winningNumber != 2 && winningNumber != 35)
            {

                Console.WriteLine($"Double Rows: {winningNumber}, {up}, {down}, {topRight}, {right}, {bottomRight}\n\nOR\n");
                Console.WriteLine($"Double Rows: {winningNumber}, {up}, {down}, {topLeft}, {left}, {bottomLeft}\n");
            }
        }
        public void DoubleRowsForColumnThree()
        {
            int oneDown = winningNumber - 1;
            int twoDown = winningNumber - 2;
            int right = winningNumber + 3;
            int left = winningNumber - 3;
            int leftOneDown = left - 1;
            int leftTwoDown = left - 2;
            int rightOneDown = right - 1;
            int rightTwoDown = right - 2;

            if (winningNumber == 3)
            {
                {
                    Console.WriteLine($"Double Rows: {winningNumber}, {oneDown}, {twoDown}, {right}, {rightOneDown}, {rightTwoDown}\n");

                }
            }
            else if (winningNumber == 36)

            {
                Console.WriteLine($"Double Rows: {winningNumber}, {oneDown}, {twoDown}, {left}, {leftOneDown}, {leftTwoDown}\n ");
            }
            else if (column3.Contains(winningNumber) && winningNumber != 3 && winningNumber != 36)
            {
                Console.WriteLine($"Double Rows: {winningNumber}, {oneDown}, {twoDown}, {right}, {rightOneDown}, {rightTwoDown}\n\nOR\n");
                Console.WriteLine($"Double Rows: {winningNumber}, {oneDown}, {twoDown}, {left}, {leftOneDown}, {leftTwoDown}\n ");
            }

        }
        public void SplitAndCorner()
        {
            int right = winningNumber + 3;
            int up = winningNumber + 1;
            int left = winningNumber - 3;
            int down = winningNumber - 1;
            int topRight = winningNumber + 4;
            int topLeft = winningNumber - 2;
            int downRight = winningNumber + 2;
            int downLeft = winningNumber - 4;


            if (winningNumber == 1)
            {
                Console.WriteLine($"Possible Splits: {winningNumber}/{right} and {winningNumber}/{up}\n ");
                Console.WriteLine($"Corner Bet: {winningNumber}, {right}, {up}, {topRight}\n");

            }
            else if (winningNumber == 34)
            {
                Console.WriteLine($"Possible Splits: {winningNumber}/{left} and {winningNumber}/{up}\n ");
                Console.WriteLine($"Corner Bet: {winningNumber}, {left}, {up}, {topLeft}\n");
            }
            else if (winningNumber == 36)
            {
                Console.WriteLine($"Possible Splits: {winningNumber}/{left} and {winningNumber}/{down}\n ");
                Console.WriteLine($"Corner Bet: {winningNumber}, {left}, {down}, {downLeft}\n");
            }
            else if (winningNumber == 3)
            {
                Console.WriteLine($"Possible Splits: {winningNumber}/{right} and {winningNumber}/{down}\n ");
                Console.WriteLine($"Corner Bet: {winningNumber}, {right}, {downRight}, {down}\n");
            }
            else if (column1.Contains(winningNumber) && winningNumber != 1 && winningNumber != 34)
            {
                Console.WriteLine($"Possible Splits: {winningNumber}/{right}, {winningNumber}/{up}, and {winningNumber}/{left}\n ");

                Console.WriteLine($"Corner Bet: {winningNumber}, {right}, {down}, {downRight} and\n{winningNumber}, {left}, {downLeft}, {down}\n");

            }

            else if (column2.Contains(winningNumber))
            {
                Console.WriteLine($"Possible Splits: {winningNumber}/{right}, {winningNumber}/{up}, {winningNumber}/{down}, and {winningNumber}/{left}\n ");
                Console.WriteLine($"Corner Bet: {winningNumber}, {right}, {up}, {topRight}\n{winningNumber}, {left}, {topLeft}, {up}\n");
                Console.WriteLine($"{winningNumber}, {down}, {downLeft}, {left}\n{winningNumber}, {right}, {downRight}, {down}\n");

                if (winningNumber == 2)
                {
                    Console.WriteLine($"Possible Splits: {winningNumber}/{right}, {winningNumber}/{up}, and {winningNumber}/{down}\n ");
                    Console.WriteLine($"Corner Bet: {winningNumber}, {right}, {up}, {topRight}\n{winningNumber}, {right}, {downRight}, {down}\n");

                }
                else if (winningNumber == 35)
                {
                    Console.WriteLine($"Possible Splits: {winningNumber}/{left}, {winningNumber}/{up}, and {winningNumber}/{down}\n ");
                    Console.WriteLine($"Corner Bet: {winningNumber}, {left}, {up}, {topLeft}\n{winningNumber}, {left}, {downLeft}, {down}\n");
                }
            }
            else if (column3.Contains(winningNumber) && winningNumber != 3 && winningNumber != 36)
            {
                Console.WriteLine($"Possible Splits: {winningNumber}/{right}, {winningNumber}/{down}, and {winningNumber}/{left}\n ");

                Console.WriteLine($"Corner Bet: {winningNumber}, {right}, {down}, {downRight} and\n{winningNumber}, {left}, {downLeft}, {down}\n");

            }
        }

    }
}
