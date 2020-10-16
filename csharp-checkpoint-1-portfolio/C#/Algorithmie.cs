using System;

namespace Checkpoint
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int[] myArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Somme(myArray));
            Console.WriteLine(ArrayAverage(myArray));
        }

        public static int Somme(int[] myArray)
        {
            int Sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Sum = Sum + myArray[i];
            }
            return Sum;
        }


        public static int ArrayAverage(int[] myArray)
        {
            int Sum = Somme(myArray);
            int Average = Sum/ myArray.Length;
            return Average;
        }

}
}


    


