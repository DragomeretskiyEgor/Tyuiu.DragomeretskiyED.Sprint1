using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DragomeretskiyED.Sprint1.Task7.V6.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "SprintReview | Выполнил: Драгомерецкий Е.Д. | СМАРТб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* SprintReview                                                               *");
            Console.WriteLine("* Вариант #6                                                                 *");
            Console.WriteLine("* Выполнил: Драгомерецкий Е.Д. | СМАРТб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным *");
            Console.WriteLine("* значениям данных, вводимых пользователем.                                  *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("                 x ");
            Console.WriteLine("    (      1    )          2 ");
            Console.WriteLine("z = ( 1 + ----  ) - 12 * x   * y ");
            Console.WriteLine("    (       2   ) ");
            Console.WriteLine("    (      x    ) ");


            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
