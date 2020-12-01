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
        static int[] arrayGrowth (int[] newArray)
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
        static void printArrayReverse(int[] newArray)
        {
            for (int i = newArray.Length-1; i >=0; i--)
			{
                Console.Write(newArray[i]+"\t");
			}
            Console.WriteLine();
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
        static void firstProject()
        {
            Console.Write("Введите количество элементов массива: ");
            int newAmount=int.Parse(Console.ReadLine());

            Console.WriteLine("Вывод массива");
            int[] myArray=createNewArray(newAmount);
            printArray(myArray);

            Console.WriteLine("Вывод массива в обратном порядке");
            printArrayReverse(myArray);
            
            Console.WriteLine("Элементы массива по возрастанию");
            arrayGrowth (myArray);
            printArray(myArray);

            Console.WriteLine("\nМаксимум массива = "+maxArray(myArray));

            Console.WriteLine("\nМинимум массива = "+minArray(myArray));

            Console.WriteLine("\nСумма массива = "+sumArray(myArray));
        }
        //------------------------------------------------------------------------------

        static void Main(string[] args)
        {

            firstProject();

            Console.ReadKey();

        }
    }
}
