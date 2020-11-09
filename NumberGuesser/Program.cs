using System;
using System.Text;

namespace NumberGuesser
{
    class Program
    {     

        static int compNumber, userNumder;
        static string userName;
        static bool inGame = false;
        static bool newGame = true;
        static string questChar;
        static int chance;

        static void Main(string[] args)
        {
            string mgr = "CompNumber = {0} | UserNumber = {1}";

            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Игра угадай число";

            Console.WriteLine("Игра угадай число");
            
            Console.WriteLine("\nВведите свое имя");
            userName = Console.ReadLine();            

            while (newGame)
            {
                inGame = true;
                Random rnd = new Random();
                compNumber = rnd.Next(100); 
                chance = 0;

                string[] joke = { "во ты лошара!", "я смотрю у тебя хуево с цыфрами!", "ну это пиздец!", "как так то!", "напряги извилины!", "LOL!", "красаучег не отгадал!" };

                Console.WriteLine("\nКомпьютер загадал число от 0 до 100. Попробуй отгадать у тебя 5 попыток");
                               
                while (inGame && chance != 5)
                {                    
                    Console.WriteLine("\nВведите число:");
                    userNumder = Int32.Parse(Console.ReadLine());

                    CheckValue(compNumber, userNumder);

                    if (chance == 5)
                    {
                        Console.WriteLine("\nЗагаданное число компьютером было {0}. {1} {2}", compNumber, userName, joke[rnd.Next(6)]);
                        CheckNewGame();
                    }
                    //Output
                    Console.WriteLine(mgr, compNumber, userNumder);

                }                
            }            
        }
        static void CheckValue (int a, int b)
        {
            chance++;

            if (a>b)
            {
                Console.WriteLine($"Загаданное число компьютером больше. Попытка: {chance}");
            }
            if (a<b)
            {
                Console.WriteLine($"Загаданное число компьютером меньше. Попытка: {chance}" );
            }
            if (a==b)
            {
                Console.WriteLine("Число отгадано - поздравляем!");
                CheckNewGame();
            }            
        }

        static void CheckNewGame()
        {
            Console.WriteLine("\nХотите еще попробывать Y/N");
            questChar = Console.ReadLine();

            switch (questChar)
            {
                case "Y":
                    newGame = true;
                    break;
                case "N":
                    Console.WriteLine("\nВы отказались от игры - как жаль!!!");
                    Console.ReadLine();
                    newGame = false;
                    break;
            }            
        }
    }
}