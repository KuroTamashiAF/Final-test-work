using System;
namespace Myprogramm
{
    class Programm
    {
        public static void FillArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
        }
        public static void PrintArray(string[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("]");
        }
        public static int CountValidElement(string[] ArrayInput)
        {
            int CountElementNewArray = 0;
            for (int i = 0; i < ArrayInput.Length; i++)
            {
                if (ArrayInput[i].Length <= 3)
                {
                    CountElementNewArray++;
                }
            }
            return CountElementNewArray;
        }
        public static string[] GetTotalArray(string[] ArrayInput, int Lenght)
        {
            string[] ResultArray = new string[Lenght];
            int k = 0;
            for (int j = 0; j < ArrayInput.Length; j++)
            {
                if (ArrayInput[j].Length <= 3)
                {
                    ResultArray[k] = ArrayInput[j];
                    k++;
                }
            }
            return ResultArray;
        }
        private static void Main(string[] args)
        {
            int size = 5;
            string[] Array = new string[size];
            FillArray(Array);
            int TotalLenght = CountValidElement(Array);
            string[] TotalResultArray = new string[TotalLenght];
            TotalResultArray = GetTotalArray(Array, TotalLenght);
            Console.WriteLine();
            PrintArray(TotalResultArray);
        }
    }
}