﻿Console.WriteLine("Введите целое число a ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 0;
    while (a > 0)
    {
        sum = sum + a % 10; 
        a = a / 10;
        i++;
    }
    
Console.WriteLine(sum);