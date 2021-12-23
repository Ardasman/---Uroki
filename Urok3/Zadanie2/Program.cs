/*
Астапов Алексей

а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
*/

int GetNum(string txt)
{
    int result;
    bool flag = false;
    do
    {
        Console.Write(txt);
        flag = int.TryParse(Console.ReadLine(), out result);
    } while (!flag);

    return result;
}

int numbers = GetNum("Введите число: ");
int nechet = 0;                                        

while (numbers != 0)
{

    if (numbers % 2 > 0)                                 
    {
        nechet += numbers;
    }

    numbers = GetNum("Введите число: ");
}

Console.WriteLine($"Сумму всех нечетных положительных чисел:  {nechet}");


