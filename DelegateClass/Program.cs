using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
namespace SimpleProject
{
    public delegate double CalcDelegate(double x, double y);
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("One", 1);
            hashtable.Add("Two", 2);
            hashtable.Add("Three", "Три");
            
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("One", "Один");
            dict.Add("Two", "Два");
            ArrayList a = new ArrayList();
            List <string>values = new List<string>();
            SortedList sortedList = new SortedList();
            sortedList.Add(2, 1110);
            sortedList.Add(1, 2140);
            sortedList.Add(3, 3150);
            for(int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"{sortedList.GetKey(i)} - {sortedList.GetByIndex(i)}");
            }

            Calculator calc = new Calculator();
            Write("Enter an expression: ");
            string expression = ReadLine();
            char sign = ' ';
            // определения знака арифметического действия
            foreach (char item in expression)
            {
                if (item == '+' || item == '-' || item ==
                '*' || item == '/')
                {
                    sign = item;
                    break;
                }
            }
            try
            {
                // получение значений операндов
                string[] numbers = expression.Split(sign);
                CalcDelegate del = null;
                switch (sign)
                {
                    case '+':
                        del = new CalcDelegate(calc.Add);
                        break;
                    case '-':
                        del = new CalcDelegate(Calculator.
                        Sub);
                        break;
                    case '*':
                        del = calc.Mult; // групповое
                                         // преобразование методов
                        break;
                    case '/':
                        del = calc.Div;
                        break;

                    default:
                        throw new
                        InvalidOperationException();
                }
                WriteLine($"Result: {del(double.Parse(numbers[0]), double.Parse(numbers[1]))}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}