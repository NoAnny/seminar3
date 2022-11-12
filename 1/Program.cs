//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void PrintIsNumberPalindrome(int number)
    {
        if (10000 < number && number < 99999)
        {
            if (number % 10 == number / 10000 && (number % 100) / 10 == (number / 1000) % 10)
            Console.WriteLine($"Число {number} - палиндром");
            else Console.WriteLine($"Число {number} - не палиндром");
        }
        else Console.WriteLine("Внимание! Введенное Вами число не является пятизначным");
        return;
    }
    
Console.WriteLine("Введите пятизначное чило");
PrintIsNumberPalindrome(int.Parse(Console.ReadLine ()!));
