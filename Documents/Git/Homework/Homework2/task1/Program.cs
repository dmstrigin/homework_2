﻿// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

Console.WriteLine("Enter your number");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("second number -> "+stringNumber[1]);

