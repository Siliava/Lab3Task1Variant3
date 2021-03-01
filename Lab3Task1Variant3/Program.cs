using System;

namespace Lab3Task1Variant3
{
    class Program
    {
        static double Summary (double x, double eps)
        {
            double sum = 0.0;
            int n = 0;
            while (true)
            {
                double item = 1.0/(2*n+1)*Math.Pow((x-1)/(x+1), 2*n+1);
                n++;
                if (Math.Abs(item) < eps)
                    break;
                sum += item;
                Console.WriteLine("n={0}\titem={1:#0.000000}\tsum={2:#0.000000}", n, item, sum);
            }
            return sum;
        }
           
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter eps");
            double eps = double.Parse(Console.ReadLine());
            double sum = Summary(x, eps);
            Console.WriteLine("\nСумма ряда для х={0} (с точностью e={1:#0.000000} равна: {2:#0.000000}", x, eps, sum);
            Console.ReadKey();


        }
    }
}
