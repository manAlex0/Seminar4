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

void FillArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

// string FindNum(int[] array, int num)
// {
//     string result = "Нет";
//     for (var i = 0; i < array.Length; i++)
//         if (array[i] == num || (array[i] *= -1) == num)
//             result = "Да";
//     return result;
// }


bool FindNum(int[] array, int num)
{
    bool numPresent = false;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num | (array[i] *= -1) == num)
            numPresent = true;
    return numPresent;
}

void PrintIndex(int[] array, int num)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == num | (array[i] *= -1) == num)
        System.Console.WriteLine($"Идекс: {i}");
    }
}


int[] array = new int[5];

FillArray(array);
PrintArray(array);

System.Console.WriteLine("Введите число: ");
int numUser = int.Parse(Console.ReadLine()!);

PrintIndex(array, numUser);
System.Console.WriteLine(FindNum(array, numUser));