// **********************************************************************************************
// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9,9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равно 29, сумма отрицательных равна -20.

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void FindSums(int[] array)
// {
//     int sumP = 0;
//     int sumN = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0)
//             sumP += array[i];
//         else
//             sumN += array[i];
//     System.Console.WriteLine($"Сумма положительных элементов массива равно: {sumP}");
//     System.Console.WriteLine($"Сумма отрицательных элементов массива равно: {sumN}");
// }

// int[] FindSums2(int[] array)
// {
//     int sumP = 0;
//     int sumN = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0)
//             sumP += array[i];
//         else
//             sumN += array[i];
//     int[] result = { sumP, sumN };
//     return result;
// }



// Console.Clear();
// int[] array = new int[12];
// FillArray(array);
// PrintArray(array);
// FindSums(array);
// int[] result = FindSums2(array);
// System.Console.WriteLine($"Сумма положительных элементов массива равно: {result[0]}");
// System.Console.WriteLine($"Сумма отрицательных элементов массива равно: {result[1]}");





// **********************************************************************************************
// Задача 32: Напишите программу замена
// элементов массива: положительный элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, 2]

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-99, 99);
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void ReplacementArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= -1;
// }

// Console.Clear();
// int[] array = new int[4];
// FillArray(array);
// PrintArray(array);
// ReplacementArray(array);
// PrintArray(array);





// **********************************************************************************************
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутвует ли заданное число в массиве.
// Пример:
// 4; массив [6, 7, 19, 345, 3] -> нет.
// -3; массив [6, 7, 19, 345, 3] -> да.

// void FillArray(int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }

// // string FindNum(int[] array, int num)
// // {
// //     string result = "Нет";
// //     for (var i = 0; i < array.Length; i++)
// //         if (array[i] == num || (array[i] *= -1) == num)
// //             result = "Да";
// //     return result;
// // }


// bool FindNum(int[] array, int num)
// {
//     bool numPresent = false;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] == num | (array[i] *= -1) == num)
//             {
//             numPresent = true;
//             break;
//             }
//     return numPresent;
// }

// void PrintIndex(int[] array, int num)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num | (array[i] *= -1) == num)
//         System.Console.WriteLine($"Идекс: {i}");
//     }
// }


// int[] array = new int[5];

// FillArray(array);
// PrintArray(array);

// System.Console.WriteLine("Введите число: ");
// int numUser = int.Parse(Console.ReadLine()!);

// PrintIndex(array, numUser);
// System.Console.WriteLine(FindNum(array, numUser));





// **********************************************************************************************
// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10, 99]
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15:
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void FillArray (int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
// }

// void PrintArray (int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }

// int FindNum(int[] array)
// {
//     int result = 0;
//     for (var i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 99 && array[i] > 10)
//         result++;
//     }
//     return result;
// }



// int[] array = new int[15];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// int result = FindNum(array);
// System.Console.WriteLine($"Колличество элементов массива в отрезке [10 99] равна: {result}");




// **********************************************************************************************
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// Пример:
// [1, 2, 3, 4, 5] -> 5 8 3
// [6, 7, 3, 6] -> 36 21

void FillArray(int[] array)
{
    for (var i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
}

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}

void FindArray(int[] array, int[] newArray)
{
    int maxIndex = array.Length - 1;
    for (int i = 0; i < maxIndex; i++)
    {
        newArray[i] = array[i] * array[maxIndex];
        maxIndex -= 1;
    }
    if (array.Length % 2 != 0)
    newArray[maxIndex] = array[array.Length/2];
}

System.Console.WriteLine("Введите количество массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
int indexNewArray = 0;
if (array.Length % 2 == 0) //нужно попробовать сделать методм!!!
    indexNewArray = 0;
else indexNewArray += 1;
int[] newArray = new int[(array.Length / 2) + indexNewArray];
FillArray(array);
PrintArray(array);
FindArray(array, newArray);
System.Console.WriteLine();
PrintArray(newArray);
