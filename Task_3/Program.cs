// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Введите целое число: ");
int number2 = int.Parse(Console.ReadLine()!);

void Multiply (int num, int num2)                     
{
    int two = number % number2;
    if ( two == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine($"не кратно, остаток: {two}");
    }
}
Multiply (number, number2);
