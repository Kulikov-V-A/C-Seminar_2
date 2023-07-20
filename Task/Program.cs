// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//Random rnd = new Random();                       //В 3-4 строке, развернутый вариант 21 строки
//int num = rnd.Next(10, 100);                     //Random rnd = new Random();-экземпляр класса рандом [10....100) 10 вкл, 100-нет 

// 54 / 10 = 5
// 54 % 10 = 4

int MaxDigit (int number)                          //Создается копия number в самой функции для ee работы (Сюда заходит rand)
{
    int first = number / 10;
    int second = number % 10;
    if (first > second)
        return first;
    else 
        return second;
}

int RandomNum ()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine($"Сгенерировалось число: {num}");
    return num;
}

int rand = RandomNum();
int maxDigit = MaxDigit(rand);
Console.WriteLine($"Максимальная цифра в числе {rand} = {maxDigit}");
