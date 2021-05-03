using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Здравствуйте, это игра вычитание чисел. \n Вы вводите количество игроков , минимальное и максимальное значение , после которых получается рандомное число. \n Ваша задача состоит в том чтобы дойти до нуля первым , используя только 1, 2, 3, 4");
            Console.WriteLine("введите свой никнейм");
            string userTry = Console.ReadLine();
            string bot = "Bot";// названия бота
            bool f = true;
            Console.WriteLine("введите максимальное и минимальное число для игры ");
            Console.WriteLine("введите минимальное число");
            var Min4islo = int.Parse(Console.ReadLine());// ввод минимального значения
            Console.WriteLine("введите максимальное число");
            var Max4islo = int.Parse(Console.ReadLine());// ввод максимального значения
            Random rand = new Random(); 
            int gameNumber = rand.Next(Min4islo, Max4islo), m; // рандомное число
            //цикл игры
            while (gameNumber > 0)
            {
                
               
                if (f)
                {
                    Console.WriteLine("{0}, ваш ход", f ? userTry : bot);
                    m = int.Parse(Console.ReadLine());
                    while (!(m >= 1 && m <= 4))
                    {
                        Console.WriteLine("Некорректный ход! {0}, повторите ввод", f ? userTry : bot);
                        m = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    m = rand.Next(1, 5); // ход компьютера
                    Console.WriteLine(bot + " походил ");
                }

                gameNumber -= m; 
                f = !f;
            }
            Console.WriteLine(0);
            Console.WriteLine("{0} победил!", f ? bot : userTry);
            Console.ReadKey();
        }
    }
}
