using System;
using System.Text;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int compNumber, userNumder;
            string mgr = "CompNumber = {0} | UserNumber = {1}";
            bool inGame = false;

            Console.Title = "Игра угадай число";
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуй отгадать у тебя 5 попыток");
            Console.WriteLine("Хотите сыграть? Y/N");

            string questChar = Console.ReadLine();

            switch (questChar)
            {
                case "Y":
                    inGame = true;
                    break;
                case "N":
                    inGame = false;
                    break;
            }

            while (inGame)
            {
                compNumber = rnd.Next(100);
                userNumder = Int32.Parse(Console.ReadLine());

                //Output
                Console.WriteLine(mgr, compNumber, userNumder);
                Console.ReadLine();
            }
        }
    }
}