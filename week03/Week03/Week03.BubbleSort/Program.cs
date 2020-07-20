using System;

namespace Week03.BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSortV1();
        }

        //  int[] array = new[] {1, 6, 4, 5, 2, 0, -1};

        //  int[] array = new[] {1, 6, 4, 5, 2, 0, -1};

        //  int[] array = new[] {1, 6, 4, 5, 2, 0, -1};

        private static void BubbleSortV2()
        {
            int[] array = new[] {1, 6, 4, 5, 2, 0, -1};

            // 1 - 6
            // 6 - 4 swap => 1, 4, 6, 5, 2, 0, -1
            // 6 - 5 swap => 1, 4, 5, 6, 2, 0, -1
            // 6 - 2 swap => 1, 4, 5, 2, 6, 0, -1
            // 6 - 0 swap => 1, 4, 5, 2, 0, 6, -1
            // 6 - -1 swap => 1, 4, 5, 2, 0, -1, 6
            // ----------------------------------- cel mai mare element in ultima poz [prima iteratie]
            // 1 - 4
            // 4 - 5
            // 5 - 2 swap => 1, 4, 2, 5, 0, -1, 6
            // 5 - 0 swap => 1, 4, 2, 0, 5, -1, 6
            // 5 - -1 swap => 1, 4, 2, 0, -1, 5, 6
            // 5 - 6 
            // ----------------------------------- ultimele 2 elemente sunt cele maxime, crescator

            // 6

            for (int j = 0; j < array.Length; j++) // nr iteratie
            {
                for (int i = 1; i < array.Length - j; i++) // 5
                {
                    Console.WriteLine($"Compar: {array[i - 1]} cu {array[i]}. Poz: array[{i - 1}] cu array[{i}]");

                    if (array[i - 1] > array[i])
                    {
                        var aux = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = aux;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void BubbleSortV1()
        {
            int[] array = new[] {1, 6, 4, 5, 2, 0, -1};

            // 1 - 6
            // 1 - 4
            // 1 - 5
            // 1 - 2
            // 1 - 0 swap => 0, 6, 4, 5, 2, 1, -1
            // 0 - -1 swap => -1, 6, 4, 5, 2, 1, 0
            // ----------------------------------- cel mai mic element in prima poz
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
