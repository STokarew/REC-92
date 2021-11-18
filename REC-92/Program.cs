using System;
using System.Linq;

namespace REC_92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            var NaturalNum = Console.ReadLine();
            Console.Write("Введите искомую цыфру: ");
            var Num = Console.ReadLine();
            var CountNum = NaturalNum.Count(c => c == char.Parse(Num));
            Console.WriteLine(string.Format($"Цыфра {Num} встречается {CountNum} раз"));
        }
    }
}
