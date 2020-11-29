using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            int count=int.Parse(Console.ReadLine());
            int[] myArray=new int[count];
            Random random=new Random();
            for (int i = 0; i < myArray.Length; i++)
			{
                myArray[i]=random.Next(100);
			}
            for (int j = 0; j < myArray.Length; j++)
			{
                Console.Write(myArray[j]+"\t");
			}
            Console.ReadKey();
        }
    }
}
