using Tyuiu.TelminovMS.Sprint1.Task5.V7.Lib;

namespace Tyuiu.TelminovMS.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
            Console.WriteLine("* до того момента (в первой половине дня), когда часовая стрелка          *");
            Console.WriteLine("* повернулась на f градусов (0<f<360, f – вещественное число).            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите угол поворота часовой стрелки (0<f<360):");
            double f = Convert.ToDouble(Console.ReadLine());

            int h = ds.AngleToHoursMinutes(f);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Полное количество часов прошедших от начала суток до того момента, когда часовая стрелка повернулась на {f} градусов: {h}");

            Console.ReadKey();
        }
    }
}
