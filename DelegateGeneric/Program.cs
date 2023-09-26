using static System.Console;
namespace SimpleProject
{
    public delegate T AddDelegate<T>(T x, T y);
    public class ExampleClass
    {
        public int AddInt(int x, int y)
        {
            return x + y;
        }
        public double AddDouble(double x, double y)
        {
            return x + y;
        }
        public static char AddChar(char x, char y)
        {
            return (char)(x + y);
        }
    }
    public delegate int AddDelegateNonGeneric(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass example = new ExampleClass();
            AddDelegate<int> delInt = example.AddInt;
            WriteLine($"The sum of integers: {delInt(8, 6)}");
            AddDelegateNonGeneric arc = example.AddInt;
          //  WriteLine($"th sum is {arc(45.10,15.15)}")
            AddDelegate<double> delDouble = example.AddDouble;
            WriteLine($"The sum of real numbers:{ delDouble(45.67, 62.81)}");
            AddDelegate<char> delChar = ExampleClass.AddChar;
            WriteLine($"The sum characters: { delChar('S', 'h')}");
        }
    }
}