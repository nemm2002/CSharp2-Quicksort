/* Write a program that sorts an array of integers using the Quick sort algorithm. */

using System;
using System.Collections.Generic;
class QuickSort
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<int> smaller = new List<int>();
        List<int> greater = new List<int>();
        List<int> result = new List<int>();
        int mainElement = arr[0];
        // check mainElement >=< each arr element and add to small or greater list depending of > <
        for (int i = 1; i < arr.Length; i++)
        {
            if (mainElement >= arr[i])
            {
                smaller.Add(arr[i]);
            }
            else
            {
                greater.Add(arr[i]);
            }

        }
        // joint smaller list + greater list = result list
        for (int i = 0; i < smaller.Count; i++)
        {
            result.Add(smaller[i]);
        }

        result.Add(mainElement);

        for (int i = 0; i < greater.Count; i++)
        {
            result.Add(greater[i]);
        }
        // print the result List
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}

