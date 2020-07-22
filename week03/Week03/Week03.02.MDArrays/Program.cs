namespace Week03._02.MDArrays
{
    using System;

    internal class Program
    {
        // https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array 
        private static void Main(string[] args)
        {
            // array of arrays
            int[][] jArray1 = new int[2][];

            jArray1[0] = new[] {1, 2, 3};
            jArray1[1] = new[] {5, 6, 7, 7};

            for (int i = 0; i < jArray1.Length; i++)
            {
                for (int j = 0; j < jArray1[i].Length; j++)
                {
                    Console.Write($"{jArray1[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        private static void MultiDimArrays()
        {
            //// two-dimensional array

            // is not an array of arrays, it is a structured matrix
            int[,] arr2d = new int[3, 2]
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            var rows = arr2d.GetLength(0);
            var cols = arr2d.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr2d[i, j]} ");
                }

                Console.WriteLine();
            }

            //var i = arr2d[0, 0]; //returns 1
            //i = arr2d[0, 1]; //returns 2
            //i = arr2d[1, 0]; //returns 3
            //i = arr2d[1, 1]; //returns 4
            //i = arr2d[2, 0]; //returns 5
            //i = arr2d[2, 1]; //returns 6
            ////arr2d[3, 0]; //throws run-time error as there is no 4th row

            //for (int i = 0; i < arr2d.; i++)
            //{

            //}
        }
    }
}
