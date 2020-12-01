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
        static void printArray(int[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
			{
                Console.Write(newArray[i]+"\t");
			}
            Console.WriteLine();
        }
        static int[] arrayReverse(int[] newArray)
        {
            int assignItem;
            for (int i = 0; i < newArray.Length; i++)
			{
                for (int j = i+1; j < newArray.Length; j++)
			    {
                    if(newArray[i]>newArray[j])
                    {
                        assignItem=newArray[i];
                        newArray[i]=newArray[j];
                        newArray[j]=assignItem;
                    }
			    }
			}
            return newArray;
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
        static int minArray(int[] newArray)
        {
            int min=newArray[0];
            for (int i = 0; i < newArray.Length; i++)
			{
                if(newArray[i]<min)
                {
                    min=newArray[i];
                }                
			}
            return min;
        }
        static int sumArray(int[] newArray)
        {
            int sum=0;
            for (int i = 0; i < newArray.Length; i++)
			{
                sum=sum+newArray[i];
			}
            return sum;
        }
        static void Main(string[] args)
        {

            Console.Write("Введите количество элементов: ");
            int newAmount=int.Parse(Console.ReadLine());
            int[] myArray=createNewArray(newAmount);
            printArray(myArray);
            
            arrayReverse(myArray);
            printArray(myArray);

            Console.WriteLine("\nМаксимум массива = "+maxArray(myArray));

            Console.WriteLine("\nМинимум массива = "+minArray(myArray));

            Console.WriteLine("\nСумма массива = "+sumArray(myArray));

            Console.ReadKey();

        }
    }
}
