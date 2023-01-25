// //Задача 1. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами. m = 3, n = 4.

// double [,] myArray = new double [3, 4];

// double min = -10;
// double max = 10;
// Random newArray = new Random();
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         myArray[i, j] = Math.Round(newArray.NextDouble() * (max - min) + min, 1);
//     }
// }

// // int height = myArray.GetLength(0);
// // int width = myArray.GetLength(1);

// for(int i = 0; i < myArray.GetLength(0); i++)
// {
//     for(int j = 0; j < myArray.GetLength(1); j++)
//     {
//         Console.Write(myArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

//Задача 2. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том,
//что оно найдено или же указание, что такого элемента нет.

// int[,] myArray = new int [3, 4];
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);

// Random newArray = new Random();
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         myArray[i, j] = newArray.Next(10);
//     }
// }
// Console.WriteLine("Данный элемент в массиве ");


// for(int i = 0; i < myArray.GetLength(0); i++)
// {
//     for(int j = 0; j < myArray.GetLength(1); j++)
//     {
//         Console.Write(myArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// if(findElement(myArray, a))
// {
//     Console.WriteLine("есть");
// }
// else
// {
//     Console.WriteLine("отсутствует");
// }

// bool findElement(int[,] myArray, int a)
// {
//     foreach (int el in myArray)
//     {
//         if(el == a)
//         {
//             return true;
//         }
//     } return false;
// }


//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] myArray = new int [3, 4];

Random newArray = new Random();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = newArray.Next(10);
    }
}

for(int i = 0; i < myArray.GetLength(0); i++)
{
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < myArray.GetLength(1); i++)
{
    int summ = 0;
    for (int j = 0; j < myArray.GetLength(0); j++)
    {
        summ = summ + myArray[j,i];
    }
    double average = Math.Round((double) summ / myArray.GetLength(0), 1); //
    int n = i + 1;
    Console.WriteLine($"Среднее арифметическое " + n + " столбца - " + average);
}