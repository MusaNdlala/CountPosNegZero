using System;

namespace CountPosNegZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double[] num = new double[5];
            while (i < num.Length)
            {
                Console.WriteLine("Please enter a number {0} of four,  ",i);
                num[i++] = Convert.ToDouble(Console.ReadLine()); 
                
            }
            int[] p = Countpnz(num);
            Console.WriteLine("positive"+p[0]);
            Console.WriteLine("negative "+p[1]);
            Console.WriteLine("zero "+p[2]);
            Console.ReadLine();
        }
        static int[] Countpnz(double[] num1)
        {
            Int16 pos = 0;
            Int16 Neg = 0;
            Int16 zero = 0;
            int[] arr = new int[3];
            Int16 iterator = 0;
            while (iterator < num1.Length)
            {
                if (num1[iterator] > 0)
                    pos++;
                if (num1[iterator] == 0)
                    zero++;
                if (num1[iterator] < 0)
                    Neg++;
                    iterator++;
            }
            arr[0] = pos;
            arr[1] = Neg;
            arr[2] = zero;
            return arr;
        }
    }
}
