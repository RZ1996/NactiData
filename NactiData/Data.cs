using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace NactiData
{
    public class Data
    {
        private double firstNumber;
        private double secondNumber;
        private double thirdNumber;

        public Data() { }

        public Data(double firstNumber, double secondNumber, double thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;

        }

        public void loadData()
        {
            bool value = true;
            while (value == true)
            {
                Console.WriteLine("Zadejte čísla: ");
                try
                {
                    Console.Write("První zadané číslo: ");
                    firstNumber = Double.Parse(Console.ReadLine());
                    Console.Write("Druhé zadané číslo: ");
                    secondNumber = Double.Parse(Console.ReadLine());
                    Console.Write("Třetí zadané číslo: ");
                    thirdNumber = Double.Parse(Console.ReadLine());
                    value = false;
                }
                catch
                {
                    Console.WriteLine("Zadejte číselnou hodnotu!");
                    value = true;
                }
            }
        }

        public void checkOperations()
        {
            while (true)
            {
                try
                {
                    Console.Write("Zadejte znak pro sčítání (+): ");
                    char sumChar = Console.ReadKey(intercept: true).KeyChar;
                    Console.WriteLine(sumChar);
                    if (sumChar != '+') throw new ArgumentException("Očekáván znak '+'.");

                    Console.Write("Zadejte znak pro násobení (*): ");
                    char multipleChar = Console.ReadKey(intercept: true).KeyChar;
                    Console.WriteLine(multipleChar);
                    if (multipleChar != '*') throw new ArgumentException("Očekáván znak '*'.");

                    Console.Write("Zadejte znak pro dělení (/): ");
                    char sumAndDivChar = Console.ReadKey(intercept: true).KeyChar;
                    Console.WriteLine(sumAndDivChar);
                    if (sumAndDivChar != '/') throw new ArgumentException("Očekáván znak '/'.");

                    // všechno je správně → ukončit smyčku
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Neplatný vstup: {ex.Message}");
                    Console.WriteLine("Zkuste to znovu.\n");
                }
            }
        }


        public double sum()
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        public double multiple()
        {
            return firstNumber * secondNumber * thirdNumber;
        }

        public double sumAndDiv()
        {
            if (thirdNumber == 0)
                throw new DivideByZeroException("Nelze dělit nulou (třetí číslo je 0).");

            return (firstNumber + secondNumber) / thirdNumber;
        }

    }
    }
