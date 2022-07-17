using System;

namespace NumberConverter // Note: actual namespace depends on the project name.
{
    public class HexadecimalToDecimal
    {
        static Dictionary<string, decimal> hexadecimalToDecimal = new()
        {
            { "0", 0 },
            { "1", 1 },
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "6", 6 },
            { "7", 7 },
            { "8", 8 },
            { "9", 9 },
            { "A", 10 },
            { "B", 11 },
            { "C", 12 },
            { "D", 13 },
            { "E", 14 },
            { "F", 15 }
        };
        static void Main()
        {
            string hexa = "1D9";
            decimal expected = 473;
            ConvertHexadecimalToDecimal(hexa);
        }

        static void ConvertHexadecimalToDecimal(string hexa)
        {
            var decimalList = new List<decimal>();
            decimal sum = 0;
            int counter = hexa.Length - 1;
            foreach (char h in hexa)
            {
                hexadecimalToDecimal.TryGetValue(h.ToString(), out decimal dec);
                dec = dec * (decimal)Math.Pow(16, counter--);
                decimalList.Add(dec);
            }
            foreach (decimal dec in decimalList)
            {
                sum = sum + dec;
            }
            Console.Write(sum);
        }
    }
}