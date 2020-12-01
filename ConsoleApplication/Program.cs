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
        static void outputAnArray(int[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
			{
                Console.Write(newArray[i]+"\t");
			}
        }
        static int maxArray(int[] newArray)
        {
            int max=newArray[0];
            for (int i = 0; i < newArray.Length; i++)
			{
                if(newArray[i]>max)
                {
                    max=newArray[i];
                }
			}
            return max;
        }
        static void Main(string[] args)
        {

            Console.Write("Введите количество элементов: ");
            int newAmount=int.Parse(Console.ReadLine());

            int[] myArray=createNewArray(newAmount);

            outputAnArray(myArray);
            
            Console.WriteLine("\nМаксимум массива = "+maxArray(myArray));

            Console.ReadKey();

        }
    }
}
