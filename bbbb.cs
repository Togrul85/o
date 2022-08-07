using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 9, 10, 11, 12 };
            int num = 8;
            Console.WriteLine(Number(arr,num));
        }
        static bool Number (int [] arr,int num)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i]== num)
                {
                    return true;
                }


            }
            return false;
        }
    }
}
