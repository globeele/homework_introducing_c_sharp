﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day >= 1 && Day <=7) {
        if (Day >= 6) {
                Console.Write("да");
            } 
        else {
                Console.Write("нет");
            }
    } 

else {
        Console.Write("Необходимо ввести цифру от 1 до 7");
    }