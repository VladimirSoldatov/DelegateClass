using System;
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
            Calculator calc = new Calculator();
            CalcDelegate delAll = null;
            CalcDelegate delDiv = calc.Div;
            delAll += delDiv; // добавления в список вызовов
            delAll -= delDiv; // удаления из списка вызовов
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