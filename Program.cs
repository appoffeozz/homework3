/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


Console.WriteLine("Введите размер массива:"); 
int length = int.Parse(Console.ReadLine()); 
int[] array = GenerateArray(length); 

PrintArray(array);

Console.WriteLine($"Количество четных чисел в масиве равно {FindEvenNumbresArray(array)}"); 

int[] GenerateArray(int length)
{
    int[] array = new int[length]; 

    Random random = new Random(); 

    for (int i = 0; i< length; i++) 
    {
        array[i] = random.Next(99, 1000); 
    }

    return array; 
}


int FindEvenNumbresArray (int[] array)
{
    int a = 0; 
    for(int i = 0; i < array.Length; i++) 
    {
        if (array[i] % 2 == 0) 
        {
            a++; 
        }
    }

    return a; 
}


void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


Console.WriteLine("Введите размер массива:"); 
int length = int.Parse(Console.ReadLine()); 


int[] array = GenerateArray(length); 

PrintArray(array);
Console.WriteLine($"Сумма не четных элементов массива равна {FindNonEvenNumbresArray(array)}"); 


int[] GenerateArray(int length)
{
    int[] array = new int[length]; 

    Random random = new Random(); 

    for (int i = 0; i< length; i++) 
    {
        array[i] = random.Next(0, 10); 
    }

    return array;
}


int FindNonEvenNumbresArray (int[] array)
{
    int a = 0; 
    for(int i = 0; i < array.Length; i += 2) 
    {
        a += array[i]; 
    }

    return a; 
}


void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


Console.WriteLine("Введите размер массива:"); 
int length = int.Parse(Console.ReadLine());


double[] array = GenerateArray(length); 

PrintArray(array);
Console.WriteLine($"Максимальный элемент массива равен {FindMaxNumberArray(array)}"); 
Console.WriteLine($"Минимальный элемент массива равен {FindMinNumberArray(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {FindMaxNumberArray(array) - FindMinNumberArray(array)}"); // вывод в консоль разницы между результатами вывозов методов


double[] GenerateArray(int length)
{
    double[] array = new double[length]; 

    Random random = new Random(); 

    for (int i = 0; i< length; i++) 
    {
        array[i] = random.Next(0, 100) / 10.0; 
    }

    return array; 
}


double FindMinNumberArray (double[] array)
{
    double min = 100; 

    for(int i = 0; i < array.Length; i++) 
    {
        if (min > array[i]) 
        {
            min = array[i]; 
        }
    }
    
    return min; 
}


double FindMaxNumberArray (double[] array)
{
    double max = 0; 

    for(int i = 0; i < array.Length; i++) 
    {
        if (max < array[i]) 
        {
            max = array[i]; 
        }
    }
    
    return max; 
}


void PrintArray(double[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); 
}
*/