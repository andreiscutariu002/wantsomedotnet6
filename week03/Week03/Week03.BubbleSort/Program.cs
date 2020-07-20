using System;

namespace Week03.BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 6, 4, 5, 2, 0, -1};

            // 1 - 6
            // 1 - 4
            // 1 - 5
            // 1 - 2
            // 1 - 0 swap => 0, 6, 4, 5, 2, 1, -1
            // 0 - -1 swap => -1, 6, 4, 5, 2, 1, 0
            // ----------------------------------- cel mai element in prima poz
            // 

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    Console.WriteLine($"Compar: {array[i]} cu {array[j]}. Poz: array[{i}] cu array[{j}]");

                    if (array[i] > array[j])
                    {
                        var aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Array sortat");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
