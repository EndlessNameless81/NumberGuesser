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
            

            while (newGame)
            {
                Console.WriteLine("\nКомпьютер загадал число от 0 до 100. Попробуй отгадать у тебя 5 попыток");
                Console.WriteLine("\nХотите сыграть? Y/N");
                
                questChar= Console.ReadLine();

                switch (questChar)
                {
                    case "Y":
                        inGame = true;
                        Random rnd = new Random();
                        compNumber = rnd.Next(100);
                        Console.WriteLine("\nИгра начата! Введите свое имя");
                        userName = Console.ReadLine();
                        chance = 5;
                        break;
                    case "N":
                        inGame = false;
                        newGame = false;
                        Console.WriteLine("\nВы отказались от игры - как жаль!!!");
                        Console.ReadLine();
                        break;
                }

                while (inGame && chance != 0)
                {                    
                    Console.WriteLine("\nВведите число:");
                    userNumder = Int32.Parse(Console.ReadLine());

                    CheckValue(compNumber, userNumder);
                    chance--;
                    if (chance == 0)
                        newGame = false;
                    //Output
                    Console.WriteLine(mgr, compNumber, userNumder);

                }

                if (chance == 0)
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
        static void CheckValue (int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine("Загаданное число компьютером больше. Попытка:" + chance);
            }
            if (a<b)
            {
                Console.WriteLine("Загаданное число компьютером меньше. Попытка:" + chance);
            }
            if (a==b)
            {
                Console.WriteLine("Число отгадано - поздравляем!");
                inGame = false;
            }
        }
    }
}