using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.setStart(10);
            arith.setStep(2);
            Console.WriteLine("Установка значений арифметической прогрессии");
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            
            arith.reset();
            Console.WriteLine("Сброс значений");
            
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("");
            
            GeomProgression geom = new GeomProgression();
            geom.setStart(10);
            geom.setStep(2);
            Console.WriteLine("Установка значений геометрической прогрессии");
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            
            geom.reset();
            Console.WriteLine("Сброс значений");

            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());

            Console.ReadKey();

        }
    }
}
