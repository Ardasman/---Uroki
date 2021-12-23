/*
Астапов Алексей

а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
*/

Complex z1 = new Complex(2,5);
Complex z2 = new Complex(3,-4);

Console.WriteLine($"Комплексное число 1: {z1}");
Console.WriteLine($"Комплексное число 2: {z2}");

Complex z3 = z1.Sum(z2);   // сложение
Complex z4 = z1.Diff(z2);  // вычитание
Complex z5 = z1.Mult(z2);  // умножение

Console.WriteLine("Какое действие отобразить: сложение, вычитание, умножение ?");
var txt = Console.ReadLine();

switch (txt)
{
    case "сложение": 
    z3.ShowSum();
    break;

    case "вычитание":
    z4.ShowDiff();
    break;

    case "умножение":
    z5.ShowMult();
    break;

    default:
    Console.WriteLine("Программа прервана. Вы не выбрали ни один из предложенных вариантов или допустили ошибку");
    break;
}