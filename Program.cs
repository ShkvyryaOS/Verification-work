﻿string [] CreateArray()
 { 
    Console.WriteLine("Введите количество элементов в массиве ");
    int size=Convert.ToInt32(Console.ReadLine());
    string [] arr= new string[size];
        for(int i=0; i<size; i++)
        {
        Console.WriteLine($"Ввведите {i} элемент массива");
        arr[i]=Console.ReadLine();
        }
 return arr;
 }

 int CountElement(string []array, int size)
 {
    int count=0;
        for (int i=0; i<array.Length; i++)
               if  (array[i].Length<=size)
                count++;
        
return count;
 }
