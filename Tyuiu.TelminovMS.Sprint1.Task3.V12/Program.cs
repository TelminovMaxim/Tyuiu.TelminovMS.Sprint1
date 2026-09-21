using Tyuiu.TelminovMS.Sprint1.Task3.V12.Lib;

namespace Tyuiu.TelminovMS.Sprint1.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника   *");
            Console.WriteLine("* по длинам двух катетов                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double lengthCathetus1, lengthCathetus2;

            Console.WriteLine("Введите длину первого катета: ");
            lengthCathetus1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета: ");
            lengthCathetus2 = Convert.ToDouble(Console.ReadLine());

            var res = ds.TriangleArea(lengthCathetus1, lengthCathetus2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Площадь прямоугольного треугольника: {res}");

            Console.ReadKey();
        }
    }
}
