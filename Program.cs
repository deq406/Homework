using System;
using System.Collections.Generic;
namespace homework111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество цифр для вычисления НОД");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Вводите цифры");
            int[] Massiv = new int[n];
            for(int i = 0; i < Massiv.Length; i++)
            {
                Massiv[i]=int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Введите три числа");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
           Console.WriteLine(multiGCD(Massiv));
            Console.WriteLine("Введите массив из пяти чисел");
            int[] Mass=new int[5];
            for (int i = 0; i < Mass.Length; i++) 
            {

                Mass[i] = int.Parse(Console.ReadLine());
             }
            Console.WriteLine(Max(Mass, 4));
            Console.WriteLine("Введите вещественый массив из пяти чисел");
            float[] Mas = new float[5];
            for(int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine(find(Mas));
            string str1 = "asdasd";
            string str2 = "qwerewq";
           Console.WriteLine(Concatat(str1, str2));
            FilterDigit(7, 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17);

        }
        static int FilterDigit(int number,params int[] n) 
        {
            for(int i = 0; i < n.Length; i++)
            {
                int temp = n[i];
                
                if (n[i]%10 == number||n[i]/10 == number)
                {
                    Console.WriteLine(temp);
                }
            }
            return 0;
        }
        static string Concatat(string str1, string str2)
        {
            var result = new List<char>();
            foreach (char c1 in str1)
            {
                foreach (char c2 in str2)
                {
                    if (c1 != c2 && ! result.Contains(c1))
                    {
                        result.Add(c1);
                    }
                }
            }
            foreach (char c2 in str2)
            {
                foreach (char c1 in str1)
                {
                    if (c2 != c1 && !result.Contains(c2))
                    {
                        result.Add(c2);
                    }
                }
            }
            return string.Concat(result);
        }

            public static float find(float [] a)
            {
            float leftsum = 0, index = -1, rightsum = 0;

                for (int i = 1; i < a.Length-1; i++)
                {
                leftsum = 0;
                rightsum = 0;

                    for (int j = 0; j < i; j++)
                    {
                        leftsum += a[j];
                    }
                    for (int j = i + 1; j< a.Length; j++)
                    {
                        rightsum += a[j];

                    }
                if (leftsum == rightsum)
                {

                    index = i;
                }
                //else 
                //{
                //    Console.WriteLine(leftsum + "левая сумма");
                //    Console.WriteLine(rightsum + "правая сумма");
                //    index = -1;
                //}


                }
            return index;
            }
           
       
        static int classicGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int multiGCD(int[] n)
        {
            if (n.Length == 0) return 0;
            int i, gcd = n[0];
            for (i = 0; i < n.Length - 1; i++)
                gcd = classicGCD(gcd, n[i + 1]);
            return gcd;
        }
        static int Max(int[] a, int index)
        {

            int max = 0;

            if (index < a.Length)
            {

                max = a[index];

                for (int i = 0; i < a.Length; i++)
                {
                    if (max < a[i])
                    {
                        max = Max(a,i);
                    }

                }


                return max;

            }
            else
            {

                return 0;
            }

        }
    }
}
