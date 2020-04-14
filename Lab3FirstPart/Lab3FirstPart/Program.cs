using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3FirstPart
{
    class Program
    {
        delegate double OperationDelegate(double x);

        static double SquareRootOfAbsolute(double number) => Math.Sqrt(Math.Abs(number));

        static double CubeExponentiation(double number) => Math.Pow(number, 3);

        static double AddDefaultNumber(double number) => number + 3.5;

        static OperationDelegate[] _operations = new OperationDelegate[3]
        {
            SquareRootOfAbsolute,
            CubeExponentiation,
            AddDefaultNumber
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows one by one." +
                "\nThey should be look line {0 x} or {1 x} чи {2 x}(x must be a real value)." +
                "\nIf this condition will be adhered, one of the functions should be performed:" +
                "\n\t0-- sqrt(abs(x))" +
                "\n\t1-- x ^ 3" +
                "\n\t2-- x + 3, 5 " +
                "\nIf the entered row will not adhere this condition, the program will end it`s execution");
            while(true)
            {
                try
                {
                    string [] input = Console.ReadLine().Split(' ');
                    int operation = Convert.ToInt32(input[0]);
                    double number = Convert.ToDouble(input[1]);
                    Console.WriteLine(_operations[operation](number));
                }
                catch(System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid operation");
                    break;
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Invalid type of arguments! You need to write two numbers in such format: \n(0) (1)\nWhere (0) is number from 0 to 2, (1) is number,  over which the operation will be performed");
                    break;
                }         
            }
            Console.WriteLine("<----Press any button to do final exit from the program---->");
            Console.ReadKey();
        }
    }
}
