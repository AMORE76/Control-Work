﻿/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] AddNewValueToArray(string[] arr, string newRow)
{
    string[] newArr = new string[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    newArr[newArr.Length - 1] = newRow;
    return newArr;
}

string[] InputArrayByUser()
{
    string[] arr = new string[0];
    while (true)
    {
        Console.Write("Введите строку(и) с клавиатуры. После завершения ввода введите с клавиатуры - Q. : ");
        string userInformation = Console.ReadLine()!;
        if (userInformation == "q" || userInformation == "Q") break;
        else arr = AddNewValueToArray(arr, newRow: userInformation);
    }
    return arr;
}