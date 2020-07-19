using System;

namespace BubbleSortSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {7, 4, 5, 2};

            for (int i = 0; i < array.Length; i++) {
               
               System.Console.WriteLine($"IT {i}");

                for (int j = 0; j < array.Length - i - 1; j++) {
                    System.Console.WriteLine($"Compare: array[{j}] with array[{j + 1}] = {array[j]}, {array[j + 1]}");

                    if(array[j] > array[j + 1]) {
                        var aux = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = aux;
                    }
                }

                for (int k = 0; k < array.Length; k++){
                    System.Console.Write(array[k] + " ");
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }

            for (int k = 0; k < array.Length; k++){
                System.Console.Write(array[k] + " ");
            }
            System.Console.WriteLine();
        }
    }
}
