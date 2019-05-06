using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {

     static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;

            string title =
                                              @"
                     ██▀███   ▒█████   █    ██  ██▓    ▓█████▄▄▄█████▓▄▄▄█████▓▓█████ 
                    ▓██ ▒ ██▒▒██▒  ██▒ ██  ▓██▒▓██▒    ▓█   ▀▓  ██▒ ▓▒▓  ██▒ ▓▒▓█   ▀ 
                    ▓██ ░▄█ ▒▒██░  ██▒▓██  ▒██░▒██░    ▒███  ▒ ▓██░ ▒░▒ ▓██░ ▒░▒███   
                    ▒██▀▀█▄  ▒██   ██░▓▓█  ░██░▒██░    ▒▓█  ▄░ ▓██▓ ░ ░ ▓██▓ ░ ▒▓█  ▄ 
                    ░██▓ ▒██▒░ ████▓▒░▒▒█████▓ ░██████▒░▒████▒ ▒██▒ ░   ▒██▒ ░ ░▒████▒
                    ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░▓  ░░░ ▒░ ░ ▒ ░░     ▒ ░░   ░░ ▒░ ░
                      ░▒ ░ ▒░  ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░ ▒  ░ ░ ░  ░   ░        ░     ░ ░  ░
                      ░░   ░ ░ ░ ░ ▒   ░░░ ░ ░   ░ ░      ░    ░        ░         ░   
                       ░         ░ ░     ░         ░  ░   ░  ░                    ░  ░
                                                                  
                        ";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title));

            string text = "Enter any key to begin";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) +"}", text));

            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Array array = new Array();
            array.ArrayOfNumbers();
            Console.WriteLine("Winning Bets:\n");
            array.OddOrEven();
            array.Colors();
            array.LowAndHigh();
            array.Dozens();
            array.Columns();
            array.Streets();
            array.DoubleRowsForColumnOne();
            array.DoubleRowsForColumnTwo();
            array.DoubleRowsForColumnThree();
            array.SplitAndCorner();
            Console.ReadKey();

         
        }
    }
}
