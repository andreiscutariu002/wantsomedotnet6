﻿using System;

namespace Week03.ConsoleApp
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices.WindowsRuntime;

    class Program
    {
        static void Main(string[] args)
        {
            var result = Ex4(new int[] { 2, 12, 16, 3, 15, 17, 3 });
            var result2 = Ex4(new int[] { 1, 2, 3, 4});

            var duplicates = Ex4GetDuplicates(new int[] {1, 2, 3, 4});
            var duplicates2 = Ex4GetDuplicates(new int[] { 2, 12, 16, 16, 3, 15, 17, 3 });
        }

        //Algorithm to find if Array contains duplicates?
        static bool Ex4(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        //Console.WriteLine("The array contains duplicates!");
                        return true;
                    }
                }
            }

            //Console.WriteLine("The array does not contain duplicates!");
            return false;
        }

        //Algorithm to find if Array contains duplicates?
        static List<int> Ex4GetDuplicates(int[] a)
        {
            List<int> duplicates = new List<int>();
            
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        //Console.WriteLine("The array contains duplicates!");
                        duplicates.Add(a[i]);
                    }
                }
            }

            //Console.WriteLine("The array does not contain duplicates!");
            return duplicates;
        }

        //EX
        //LISTEN-SILENT
        //TRIANGLE-INTEGRAL
        //Write a Program which checks if two Strings are Anagram or not?
        static bool Ex7Anagram(string a, string b)
        {
            if (a.Length == b.Length)
            {
                char[] aCharArray = a.ToCharArray();
                char[] bCharArray = b.ToCharArray();
                Array.Sort(aCharArray);
                Array.Sort(bCharArray);
                
                    for (int i = 0; i > a.Length; i++)
                {
                    if (aCharArray[i] != bCharArray[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        //Find all pairs (2 elements) of elements in an integer array, whose sum is equal to a given number
        static void Ex2(int[] array, int sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        Console.WriteLine(array[i] + "+" + array[j] + "=" + sum);
                    }
                }
            }
        }

        // functie simpla
        // nu are input (nu are parametri)
        // nu are output (nu are return, "intoarce void"
        // SimpleFunction() - semnatura (nume functie + lista de parametri)
        // semnaturile functiilor - unice
        static void SimpleFunction()
        {
            if (DateTime.Now.Year == 2020)
            {
                return;
            }

            Console.WriteLine("Alt cod ...");
        }

        // functie simpla
        // are input, un intreg
        // nu are output
        // SimpleFunction(int number) - semnatura
        static void SimpleFunction(int number)
        {
        }

        // functie 
        // nu are input
        // dar are output, intoarce un tip
        // FunctionWithReturn() - semnatura
        static int FunctionWithReturn()
        {
            if (DateTime.Now.Year == 2020)
            {
                return -1;
            }

            Console.WriteLine("Alt cod ...");
            return 2;
        }

        // functie 
        // are input
        // dar are output, intoarce un tip
        // FunctionWithReturn(int a) - semnatura
        static int FunctionWithReturn(int a)
        {
            if (DateTime.Now.Year == 2020)
            {
                return -1;
            }

            Console.WriteLine("Alt cod ...");
            return 2;
        }

        // functie 
        // are input
        // dar are output, intoarce un tip
        // FunctionWithReturn(int a, int b) - semnatura
        static int FunctionWithReturn(int a, int b)
        {
            return a + b;
        }
    }
}
