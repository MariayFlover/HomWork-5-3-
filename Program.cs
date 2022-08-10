
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreatRondomArray(int size,int minValue,int maxValue)
{
    int[] Array=new int[size];
    for(int i=0; i<size; i++)
    {
        Array[i]=new Random().Next(minValue,maxValue+1);
    }
    return Array;
}

void ShowArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
}


int NumPositive (int[] array, int min, int max)
{
  int count = 0;
 for(int i=0;  i < array.Length; i++)
    {
      if(array[i] %2 ==0) count++;
    }
    return count;
}   
Console.Write("Input size of array: ");
int size=Convert.ToInt32(Console.ReadLine());

Console.Write("Input min positive number: ");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Input max positive number: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] array=CreatRondomArray(size,min,max);
ShowArray(array);

Console.Write($"Кол-во четных чисел в массиве  {NumPositive (array,min,max)}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0
/*
int[] CreatRondomArray(int size,int minValue,int maxValue)
{
    int[] Array=new int[size];
    for(int i=0; i<size; i++)
    {
        Array[i]=new Random().Next(minValue,maxValue+1);
    }
    return Array;
}


void ShowArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

int SumOfNegativeElements(int[] array)
{
int sum = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(i % 2 == 0) sum = sum + 0; 
            else sum = sum + array[i] ;
    }
     return sum;
}

Console.Write("Input size of array: ");
int size=Convert.ToInt32(Console.ReadLine());

Console.Write("Input min positive number: ");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Input max positive number: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] array=CreatRondomArray(size,min,max);
ShowArray(array);

Console.Write($"сумму элементов, стоящих на нечётных позициях =  {SumOfNegativeElements (array)}");*/




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
int[] CreatRondomArray(int size, int minValue, int maxValue)
{
    int[] Array=new int[size];
    for(int i=0; i<size; i++)
    {
        Array[i]=new Random().Next(minValue,maxValue+1);
    }
    return Array;
}

void ShowArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

int MaxDifferenceMin(int[] array)
{
   int max=0;
   int min=0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i]; 
    }
    for(int i = 0; i < array.Length; i++)
    {
        
        if(array[i] < min) min = array[i];
    }
    int difference = max - min;

    return difference;
}

int[] newarray = CreatRondomArray(10,1,100);
ShowArray(newarray);
Console.WriteLine($"разница между максимальным и минимальным элементов массива =" + MaxDifferenceMin(newarray));*/