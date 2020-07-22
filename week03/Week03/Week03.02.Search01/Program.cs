using System;

namespace Week03._02.Search01
{
    class Program
    {
        // daca un un dataset de lungime N
        // targetul e cu fiecare iteratie sa injumatatim datesetul ce urmeaza a fi scanatat
        // devide et empera O(log(N))
        static void BinarySearch()
        {
            int[] array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int start = 0, end = array.Length;
            var elem = -1;
            var mid = array.Length / 2;
            var elemPos = -1;

            while (start <= end)
            {
                if (elem > array[mid])
                {
                    start = mid + 1;
                    mid = (end + start) / 2;
                }
                else if (elem < array[mid])
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                }
                else
                {
                    elemPos = mid;
                    break;
                }
            }
         
            Console.WriteLine($"Pozitia elementului este: {elemPos}.");
        }

        static void Main(string[] args)
        {
            int[] array = new[] { 1, 6, 4, 5, 2, 0, -1 };

            int valueToSearch = 1;

            // parcurgem array
            // fiecare cu valueToSearch
            // am nevoie de n interatii

            // Linear Search 
            // un array - start => end (N pasi) =>

            // complexitate 
            // daca avem dataset (are un nr N de elemente)
            // daca il parcurgem de la start => final => O(N)
            // o cautare liniara are complixate O(N)

            // fiecare element odata din dataset => O(N)
            // fiecare element cu fiecare element => O(N*N) - O(N) la patrat
        }

        //Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?
        // pozitia unde avem element majoritar
        // -1 in caz ca nu avem element majoritar
        static int Ex6(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }

                if (count > array.Length / 2)
                {
                    return i;
                }
            }

            return -1;
        }

        static int[] Ex19MinMax(int[] arr)
        {
            int min1 = arr[0], min1pos = -1, min2 = arr[0], max1 = arr[0], max1pos = -1, max2 = arr[0], sumMin, sumMax;
            int[] arrayMinMax = new int[2];
            
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] < min1)
                {
                    min1 = arr[i];
                    min1pos = i;
                }
            }

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] < min2 && min1pos != i)
                {
                    min2 = arr[i];
                }
            }
            
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] > max1)
                {
                    max1 = arr[i];
                    max1pos = i;
                }
            }
            
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] > min2 && max1pos != i)
                {
                    max2 = arr[i];
                }
            }
            
            sumMin = min1 + min2;
            sumMax = max1 + max2;
            arrayMinMax[0] = sumMin;
            arrayMinMax[1] = sumMax;
            
            return arrayMinMax;
        }


        // complexities
        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) // n
            {
                for (int j = 0; j < array.Length; j++) // n
                {
                    Console.WriteLine(array[i]);
                }
            }
            // =>
            // n * n

            for (int i = 0; i < array.Length; i++) // n
            {
                for (int j = 0; j < array.Length; j++) // n
                {
                    for (int k = 0; k < array.Length; k++) // n
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            // =>
            // n * n * n 

            int n = 1000;
            int m = 200;

            for (int i = 0; i < n; i++) // n
            {
                for (int j = 0; j < m; j++) // m
                {
                    Console.WriteLine(array[i]);
                }
            }
            // =>
            // n * m
        }
    }
}
