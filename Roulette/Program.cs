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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
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

            Console.WriteLine(title);
            Console.WriteLine("Enter any key to begin!");
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
