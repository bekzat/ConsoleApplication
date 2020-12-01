using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static int[] createNewArray(int amount)
        {
            Random random = new Random();
            int[] newArray=new int[amount];
            for (int i = 0; i < newArray.Length; i++)
			{
                newArray[i]=random.Next(100);
			}
            return newArray;
        }
        static void outputAnArray(int[] outputNewArray)
        {
            for (int i = 0; i < outputNewArray.Length; i++)
			{
                Console.Write(outputNewArray[i]+"\t");
			}
        }
        static void Main(string[] args)
        {

            Console.Write("Введите количество элементов: ");
            int newAmount=int.Parse(Console.ReadLine());

            int[] myArray=createNewArray(newAmount);

            outputAnArray(myArray);

            Console.ReadKey();

        }
    }
}
