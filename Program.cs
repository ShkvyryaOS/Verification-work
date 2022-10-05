string [] CreateArray()
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