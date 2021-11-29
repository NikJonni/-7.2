using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Calcube(a);
            Console.ReadKey();
        }
        static void Calcube(double a)
        {
            double S = 6 * (a * a);// нахождение поверхности куба
            double V = a * a * a;
            Console.WriteLine("Площадь поверхности куба равна = {0:f1}", S);
            Console.Write("Объем куба равна = {0:f1}", V);
        }
    }
}
