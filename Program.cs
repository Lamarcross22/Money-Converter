using System;
using System.Globalization;
using System.Threading;
using System.Linq;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Money Converter.");


            double number1, number2, number3, number4;

            //take in numbers 
            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            //average
            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",  number1, number2, number3, number4, result);
            //max
            double[] pricevalue = new double[4];
            pricevalue[0] = number1;
            pricevalue[1] = number2;
            pricevalue[2] = number3;
            pricevalue[3] = number4;
            double max = pricevalue.Max();
            double min = pricevalue.Min();
            Console.WriteLine("This is your Max: {0}",max);
            Console.WriteLine("This is your Min: {0}",min);
            Console.WriteLine("Your sum total is");
            double sum = pricevalue.Sum();
            
            Console.Writeline(sum.ToString("C3", CultureInfo.CreateSpecificCulture("en-US")));
            Console.Writeline(sum.ToString("C3", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.Write(sum.ToString("C3", CultureInfo.CreateSpecificCulture("th-TH")));
            Console.Write(sum.ToString("C3", CultureInfo.CreateSpecificCulture("ja-JP")));


            

        }
    }
}
    

