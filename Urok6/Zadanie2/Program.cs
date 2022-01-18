/* Алексей Астапов

Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
Использовать массив (или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
Пусть она возвращает минимум через параметр (с использованием модификатора out). 
*/

Fun.Print(@"Выберите функцию, введя ее номер:
            1. x * x - 50 * x + 10
            2. функция возвидения в куб
            3. функция синуса
            Ваш выбор:");

var vibor = Fun.GetNum(Console.ReadLine());

Fun.Print("Выберите начальное значение промежутка функции\nВаш выбор:");
double nachalo = Fun.GetNum(Console.ReadLine());

Fun.Print("Выберите конечное значение промежутка функции\nВаш выбор:");
double konec = Fun.GetNum(Console.ReadLine());

Fun.Print("Выберите шаг для промежутка\nВаш выбор:");
double shag = Fun.GetNum(Console.ReadLine());

double min = double.MaxValue;

switch (vibor)
{
    case 1:
        Fun.SaveFunc("data.bin", nachalo, konec, shag, Fun.myFun1);
        Fun.Load("data.bin", out min);
        Fun.ShowFun("f(x)=y*y-50*y+10 = ", min);
        break;
    case 2:
        Fun.SaveFunc("data.bin", nachalo, konec, shag, Fun.myFun2);
        Fun.Load("data.bin", out min);
        Fun.ShowFun("f(x) = y^3 = ", min);
        break;
    case 3:
        Fun.SaveFunc("data.bin", nachalo, konec, shag, Fun.myFun3);
        Fun.Load("data.bin", out min);
        Fun.ShowFun("f(x) = Sin(y) = ", min);
        break;
}
