using System;
using System.Collections.Generic;
using System.Diagnostics;

Random random = new Random();

List<int> list10 = GenerateRandomList(10, random);
List<int> list100 = GenerateRandomList(100, random);
List<int> list1000 = GenerateRandomList(1000, random);
List<int> list10000 = GenerateRandomList(10000, random);
List<int> list100000 = GenerateRandomList(100000, random);

Stopwatch bubblewatch10 = new Stopwatch();
bubblewatch10.Start();
RunBubblesort(list10);
bubblewatch10.Stop();

Console.WriteLine($"Tid för bubblesort 10: {bubblewatch10.ElapsedMilliseconds} ms");

Stopwatch bubblewatch100 = new Stopwatch();
bubblewatch100.Start();
RunBubblesort(list100);
bubblewatch100.Stop();
Console.WriteLine($"Tid för bubblesort 100: {bubblewatch100.ElapsedMilliseconds} ms");


Stopwatch bubblewatch1000 = new Stopwatch();
bubblewatch1000.Start();
RunBubblesort(list1000);
bubblewatch1000.Stop();

Console.WriteLine($"Tid för bubblesort 1000: {bubblewatch1000.ElapsedMilliseconds} ms");

Stopwatch bubblewatch10000 = new Stopwatch();
bubblewatch10000.Start();
RunBubblesort(list10000);
bubblewatch10000.Stop();

Console.WriteLine($"Tid för bubblesort 10000: {bubblewatch10000.ElapsedMilliseconds} ms");

Stopwatch bubblewatch100000 = new Stopwatch();
bubblewatch100000.Start();
RunBubblesort(list100000);
bubblewatch100000.Stop();

Console.WriteLine($"Tid för bubblesort 100000: {bubblewatch100000.ElapsedMilliseconds} ms");


static List<int> GenerateRandomList(int size, Random random)
{
    List<int> list = new List<int>(size);
    for (int i = 0; i < size; i++)
    {
        list.Add(random.Next(0, 1001)); 
    }
    return list;
}


static void RunBubblesort(List<int> list)
{
    for (int i = 0; i < list.Count - 1; i++)
    {
         for (int j = 0; j < list.Count - 1 - i; j++)
         {
            if (list[j] > list[j + 1])
            {
                
                int temp = list[j];
                list[j] = list[j + 1];
                list[j + 1] = temp;
            }
        }
    }
}

 static void InsertionSort(List<int>list)
{
    for (int i = 1; i < list.Count; i++)
    {
        int key = list[i];
        int j = i - 1;

        while (j >= 0 && list[j] > key)
        {
            list[j + 1] = list[j];
            j--;
        }

        list[j + 1] = key;
    }
}

list10 = GenerateRandomList(10,random);
list100 = GenerateRandomList(100,random);
list1000 = GenerateRandomList(1000,random);
list10000 = GenerateRandomList(10000,random);
list100000 = GenerateRandomList(100000,random);

Stopwatch InsertionWatch10 = new Stopwatch();
InsertionWatch10.Start();
InsertionSort(list10);
InsertionWatch10.Stop();
Console.WriteLine($"Tid för Insertionsort 10: {InsertionWatch10.ElapsedMilliseconds} ms");

Stopwatch InsertionWatch100 = new Stopwatch();
InsertionWatch100.Start();
InsertionSort(list100);
InsertionWatch100.Stop();
Console.WriteLine($"Tid för Insertionsort 100: {InsertionWatch100.ElapsedMilliseconds} ms");

Stopwatch InsertionWatch1000 = new Stopwatch();
InsertionWatch1000.Start();
InsertionSort(list1000);
InsertionWatch1000.Stop();
Console.WriteLine($"Tid för Insertionsort 1000: {InsertionWatch1000.ElapsedMilliseconds} ms");

Stopwatch InsertionWatch10000 = new Stopwatch();
InsertionWatch10000.Start();
InsertionSort(list10000);
InsertionWatch10000.Stop();
Console.WriteLine($"Tid för Insertionsort 10000: {InsertionWatch10000.ElapsedMilliseconds} ms");

Stopwatch InsertionWatch100000 = new Stopwatch();
InsertionWatch100000.Start();
InsertionSort(list100000);
InsertionWatch100000.Stop();
Console.WriteLine($"Tid för Insertionsort 100000: {InsertionWatch100000.ElapsedMilliseconds} ms");