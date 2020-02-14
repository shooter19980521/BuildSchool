using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入:");
            string input = Console.ReadLine();
            Chinese output = int.Parse(input);
            Console.WriteLine($"輸出:{output.Value}");
            Console.ReadLine();
        }
        class Chinese
        {
            public string Value { get; set; }
            public static implicit operator Chinese(int inValue)
            {
                var change = inValue.ToString().Replace("1", "一").Replace("2", "二").Replace("3", "三").Replace("4", "四").Replace("5", "五")
                    .Replace("6", "六").Replace("7", "七").Replace("8", "八").Replace("9", "九").Replace("0", "零");//Replace舊的字串會被新的字串取代
                return new Chinese()
                {
                    Value = change
                };
            }
        }
    }
}
