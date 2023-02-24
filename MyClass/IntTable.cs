using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class IntTable
    {
        public int[,] IntArray;
        public int n;
        public IntTable(int n)
        {
            this.n = n;
            IntArray = new int[n,n];
        }
        public void ReadArrey()
        {
            Console.WriteLine("\nВведите элементы массива");
            for (int i=0; i<n;  i++)
            {
                for ( int j = 0;j<n;j++)
                {
                    IntArray[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void ShowArray()
        {
            Console.WriteLine("\nЭлементы массива:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(IntArray[i,j]+" ");
                }
                Console.Write("\n");
            }
        }
        public void Summ()
        {
            Console.WriteLine("\nВведите номер столбца, чтобы посчитать сумму его элементов");
            int s = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
                for ( int i = 0; i < n; i++)
                {
                    summ += IntArray[s,i];
                }
            Console.WriteLine("Сумма элементов столбца номер {0} равна {1}",s,summ);
        }
        public void Scalar()
        {
            Console.WriteLine("\nВведите необходимый скаляр");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) { IntArray[i,j]= s; }
                }
            }
        }
    }
}
