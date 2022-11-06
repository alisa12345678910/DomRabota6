// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateFillArray(int x)
// {
// int[] Array = new int[x];
// for (int i = 0; i < x; i++)
// {
//     Console.WriteLine($"Введите элемент массива №{i + 1} ");
//     Array[i] = Convert.ToInt32 ( Console.ReadLine());
// }
// return Array;
// }

// void CheckForPosNumbers(int[] Array)
// {
// int posCount = 0;
// for (int i = 0; i < Array.Length; i++)
// {
//     if (Array[i] > 0) posCount++;
//     Console.Write($"{Array[i]} ");
// }
// Console.WriteLine($"Количество положительных элементов равно {posCount}");
// }
// int[] mas = CreateFillArray(5);
// CheckForPosNumbers(mas);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1 ");
// Double a1=Convert.ToDouble ( Console.ReadLine());
// Console.WriteLine("Введите значение b2 ");
// Double a2=Convert.ToDouble ( Console.ReadLine());
// Console.WriteLine("Введите значение k1 ");
// Double b1=Convert.ToDouble ( Console.ReadLine());
// Console.WriteLine("Введите значение k2 ");
// Double b2=Convert.ToDouble ( Console.ReadLine());

// void FindThePoint(Double b1, Double b2, Double k1, Double k2) 
// {
// Double x = (b2 - b1) / (k1 - k2);
// Double y1 = k1 * x + b1;
// Double y2 = k2 * x + b2;

// Console.WriteLine(y1);
// Console.WriteLine(y2);
// }

// FindThePoint(a1, a2, b1, b2);
