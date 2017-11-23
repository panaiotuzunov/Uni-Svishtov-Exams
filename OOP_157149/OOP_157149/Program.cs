using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_157149
{
    class Program
    {
        static void Main(string[] args)
        {
            X objectOne = new X(); // създаваме обект от клас Х
            objectOne.text = ReadXtext();
            objectOne.number = ReadXnumber();
        }

        private static decimal ReadXnumber() // неясно условие относно свойствата на числото
        {
            decimal number = 0;

            while (number == 0)
            {
                try
                {
                    Console.Write("Insert number parameter: ");
                    number = decimal.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Incorrect number. Try again.");
                }
            }

            return number;
        }

        private static string ReadXtext() // Прочитаме текст за Х, не позволяваме въвеждане на празен string
        {
            string text = "";
            bool textIsEmpty = true;

            while (textIsEmpty)
            {
                Console.Write("Insert text parameter: ");
                text = Console.ReadLine();
                textIsEmpty = text == "";

                if (textIsEmpty)
                    Console.WriteLine("Empty string is not accepted!");
            }

            return text;
        }
    }
}
