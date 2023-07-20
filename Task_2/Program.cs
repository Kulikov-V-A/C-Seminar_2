// void Sum (int a, int b)                                  //пример использования оператора void
// {
//     System.Console.WriteLine(a + b);
// }
//  int a = 5;
//  int b = 6;

//  Sum(a, b);


//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.


int RandomNum ()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"Сгенерировалось число: {num}");
    return num;
}
int DelSecondDigit (int num)
{
    int first = num / 100;
    int second = num % 10;
    int twoDigits = first * 10 + second;
    return twoDigits;
}

int number = RandomNum();
int result = DelSecondDigit(number);
Console.WriteLine($"Получилось: {result}");