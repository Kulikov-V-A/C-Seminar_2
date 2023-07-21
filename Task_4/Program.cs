// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет
// 161 -> да

/* Мое решение
int Numbers (string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num; 
}
int number = Numbers ("Введите первое число: ");
int number2 = 7;
int number3 = 23;

void Divider (int num, int num2, int num3)                     
{
    int first = num % num2;
    int second = num % num3;
    if (first == second)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

Divider (number, number2, number3);
*/

// общее решение

int InputNum(string message)
{
Console.WriteLine(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

string Multiplicity(int number)
{
string res = "Нет";
if (number % 7 == 0 && number % 23 == 0)
res = "Да";
return res;
}

int num = InputNum("Введите целое число: ");
string result = Multiplicity(num);
Console.WriteLine(result);

