using MyStringExtensions;
using System;

namespace MyStringExtensions
{
    public static class StringExtensions
    {
        public static string ToCurrency(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string is empty or null.");
            }

            if (double.TryParse(input, out _))
            {
                return "$" + input;
            }
            else
            {
                throw new ArgumentException("Input string does not contain a valid number.");
            }
        }
    }
}

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string numericString = "123.45";
            string nonNumericString = "Hello";

            try
            {
                string currencyValue = numericString.ToCurrency();
                Console.WriteLine(currencyValue);

                string invalidCurrencyValue = nonNumericString.ToCurrency();
                Console.WriteLine(invalidCurrencyValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }
    }
}