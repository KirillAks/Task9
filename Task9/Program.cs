using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        // Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
        // После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.WriteLine("Введите целое число X =");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число Y =");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n 1 - сложение \n 2 - вычитание \n 3 - умножение \n 4 - частное ");
                Console.WriteLine("Ваш выбор:");
                int calculator = Convert.ToInt32(Console.ReadLine());
                switch (calculator)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат равен = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат равен = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат равен = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат равен = {0:f2}", x / y);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером!");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
