// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("----- Print 1-255-----");
        Console.WriteLine();
        PrintNumbers();
        Console.WriteLine("\n-----Print odd numbers between 1-255-----");
        Console.WriteLine();
        PrintOdds();
        Console.WriteLine("\n-----Print Sum-----");
        Console.WriteLine();
        PrintSum();
        Console.WriteLine("-----Iterating through an Array-----");
        Console.WriteLine();
        int[] intArr = new int[] { 1, 3, 5, 7, 9, 12, 20 };
        LoopArray(intArr);
        Console.WriteLine("\n-----Find Max-----");
        Console.WriteLine();
        int[] MaxArr = new int[] { -1, -3, -5, 30, 0, 9, 12, 20 };
        int max = FindMax(MaxArr);
        Console.WriteLine("\nThe max value is: " + max);
        Console.WriteLine("-----Get Average-----");
        Console.WriteLine();
        GetAverage(intArr);
        Console.WriteLine("-----List with Odd Numbers-----");
        Console.WriteLine();
        List<int> odd = new List<int>();
        odd = OddList();
        foreach (int ind in odd)
        {
            Console.Write(" " + ind);
        }
        Console.WriteLine("\n-----Greater than Y-----");
        Console.WriteLine();
        List<int> greater = new List<int>();
        greater.Add(2);
        greater.Add(4);
        greater.Add(5);
        greater.Add(7);
        greater.Add(9);
        greater.Add(10);
        int G = GreaterThanY(greater, 5);
        Console.WriteLine(G);
        Console.WriteLine("----Square the Values------");
        Console.WriteLine();
        SquareArrayValues(greater);
        Console.WriteLine("\n-----Eliminate Negative Numbers-----");
        Console.WriteLine();
        List<int> Negative = new List<int>();
        Negative.Add(1);
        Negative.Add(5);
        Negative.Add(10);
        Negative.Add(-1);
        Negative.Add(-2);
        EliminateNegatives(Negative);
        Console.WriteLine("\n-----Min, Max, and Average-----");
        Console.WriteLine();
        int[] MArr = new int[] { 1, 5, 10, -2 };
        MinMaxAverage(MArr);
        Console.WriteLine("-----Shifting the values in an array-----");
        Console.WriteLine();
        int[] shift = new int[] { 1, 5, 10, 7, -2 };
        ShiftValues(shift);
        Console.WriteLine("\n-----Number to String-----");
        Console.WriteLine();
        object[] ToString = new object[MArr.Length];
        ToString = NumToString(MArr);
        Console.Write("\nThe values after replaces any negative number with the string 'Dojo': ");
        foreach (var v in ToString)
        {
            Console.Write(" " + v);
        }

    }
    static void PrintNumbers()
    {
        // Print all of the integers from 1 to 255.
        for (int i = 1; i <= 255; i++)
        {
            Console.Write(i + " ");

        }
    }
    static void PrintOdds()
    {
        // Print all of the odd integers from 1 to 255.
        for (int i = 1; i <= 255; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }


        }
    }
    static void PrintSum()
    {
        int sum = 0;
        // Print all of the numbers from 0 to 255,
        for (int i = 0; i <= 255; i++)
        {
            sum = sum + i;
            Console.WriteLine(" New number: " + i + " Sum: " + sum);

        }
    }
    static void LoopArray(int[] numbers)
    {
        // Write a function that would iterate through each item of the given integer array and 
        // print each value to the console. 
        foreach (int x in numbers)
        {
            Console.Write(x + " ");
        }
    }
    static int FindMax(int[] numbers)
    {
        // Write a function that takes an integer array and prints and returns the maximum value in the array. 
        // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
        // or even a mix of positive numbers, negative numbers and zero.
        int maxElement = numbers[0];
        for (int x = 0; x < numbers.Length; x++)
        {
            Console.Write(numbers[x] + " ");
            if (numbers[x] > maxElement)
                maxElement = numbers[x];
        }
        return maxElement;
    }
    static void GetAverage(int[] numbers)
    {
        // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        int sum = 0;
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
            count = count + 1;
        }
        double average = sum / count;
        Console.WriteLine(" The average is: " + average);
    }
    static List<int> OddList()
    {
        // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
        // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
        List<int> oddInt = new List<int>();
        for (int i = 1; i <= 255; i++)
        {
            if (i % 2 != 0)
            {
                oddInt.Add(i);
            }
        }
        return oddInt;
    }
    static int GreaterThanY(List<int> numbers, int y)
    {
        // Write a function that takes an integer List, and an integer "y" and returns the number of values 
        // That are greater than the "y" value. 
        int n = 0;
        foreach (int ind in numbers)
        {
            if (ind > y)
            {
                n = n + 1;
            }
        }
        return n;
    }
    static void SquareArrayValues(List<int> numbers)
    {
        // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
        Console.Write("The values before multiply ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
            numbers[i] = numbers[i] * numbers[i];
        }
        Console.Write("\nThe values after multiply ");
        foreach (int ind in numbers)
        {
            Console.Write(ind + " ");
        }

    }
    static void EliminateNegatives(List<int> numbers)
    {
        // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        Console.Write("The values before Eliminate Negatives ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
            if (numbers[i] < 0)
            {
                numbers[i] = 0;
            }

        }
        Console.Write("\nThe values after Eliminate Negatives ");
        foreach (int ind in numbers)
        {
            Console.Write(ind + " ");
        }

    }
    public static void MinMaxAverage(int[] numbers)
    {
        // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
        // the minimum value in the array, and the average of the values in the array.
        int maxElement = numbers[0];
        int minElement = numbers[0];
        int sum = 0;
        int count = 0;
        for (int x = 0; x < numbers.Length; x++)
        {
            Console.Write(numbers[x] + " ");
            if (numbers[x] > maxElement)
                maxElement = numbers[x];
            if (numbers[x] < minElement)
                minElement = numbers[x];
            sum = sum + numbers[x];
            count = count + 1;
        }
        double average = sum / count;
        Console.WriteLine("\nThe maximum number in the array: " + maxElement + "\nThe minimum value in the array: " + minElement + "\nThe average of the values in the array: " + average);

    }
    public static void ShiftValues(int[] numbers)
    {
        Console.Write("The values before shifting: ");
        foreach (int ind in numbers)
        {
            Console.Write(ind + " ");
        }
        Console.Write("\nThe values after shifting: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == (numbers.Length - 1))
            {
                numbers[i] = 0;
            }
            else
            {
                numbers[i] = numbers[i + 1];
            }
            Console.Write(numbers[i] + " ");
        }
    }
    public static object[] NumToString(int[] numbers)
    {
        object[] array = new object[numbers.Length];
        Console.Write("The values before replaces any negative number with the string 'Dojo': ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
            if (numbers[i] < 0)
            {
                array[i] = "Dojo";
            }
            else
            {
                array[i] = numbers[i];
            }

        }
        return array;

    }











}
