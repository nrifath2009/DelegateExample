using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    class Program
    {
        public delegate int MyCalculator(int firstNumber, int secondNumber);
        public delegate void MyDelegate(int firstNumber, int secondNumber);
        static void Main(string[] args)
        {
            //MyCalculator cal = Add;
            //Console.WriteLine(cal(8, 4));
            //cal = Subtract;
            //Console.WriteLine(cal(8, 4));
            //cal = Multiply;
            //Console.WriteLine(cal(8, 4));


            //cal = delegate (int firstNumber, int secondNumber)
            //{
            //    return firstNumber / secondNumber;
            //};

            //Console.WriteLine(cal(8, 4));
            //Console.ReadKey();


            MyDelegate cal1 = Add;
            MyDelegate cal2 = Subtract;
            MyDelegate cal1cal2 = cal1 + cal2;

            Console.WriteLine("calling the first delegate...");
            cal1(8, 4);

            Console.WriteLine("calling the second delegate...");
            cal2(8, 4);

            Console.WriteLine("calling the chained delegate...");
            cal1cal2(8, 4);

            Console.ReadKey();

        }

        //static int Add(int firstNumber,int secondNumber)
        //{
        //    return firstNumber + secondNumber;
        //}
        //static int Subtract(int firstNumber, int secondNumber)
        //{
        //    return firstNumber - secondNumber;
        //}
        //static int Multiply(int firstNumber, int secondNumber)
        //{
        //    return firstNumber * secondNumber;
        //}

        static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
        static void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
    }
}
