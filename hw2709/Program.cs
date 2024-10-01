﻿using System.Xml.Serialization;

int[] arr = new int[0];
int count = 0;
int errcount = 0;
string exit = "";
while (true)
{
    Console.WriteLine("Введите число \n(для выхода введите Q)");
    exit = Console.ReadLine();
    
    if (exit == "Q")
        break;

    bool isValid = int.TryParse(exit, out int num);
    
    if (isValid)
    {
        Array.Resize(ref arr, count + 1);
        arr[count] = num;
        count++;
    }
    else
    {   
        errcount++;
        Console.WriteLine("Данные введены неверно. Вывод: ");
        
        foreach (var element in arr)
        {
            Console.WriteLine(element);
        }
        
        while (true)
        {
            Console.WriteLine("Очистить - 1\nПродолжить - 2\nВыйти - 3");
            string act = Console.ReadLine();

            if (act == "1")
            {
                arr = new int[0];
                count = 0;
                continue;
            }
            
            if (act == "2")
            {
                break;
            }
            
            if (act == "3")
            {
                Console.WriteLine($"Кол-во элементов {count}\nКол-во ошибок {errcount}");
                return;
            }
        }
    }
}
Console.WriteLine("Вывод: ");
foreach (var element in arr)
{
    Console.WriteLine(element);
}