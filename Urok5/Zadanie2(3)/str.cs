using System.IO;
using System.Linq;
class Str
{
    public bool Sravn(String str1, String str2) // Метод сравнения двух выражений
    {
        char[] x = str1.ToCharArray();
        char[] y = str2.ToCharArray();

        if (str1.Length != str2.Length) return false;   // Сравниваем длины строк, если разные дальше сравнивать нет смысла

        Array.Sort(x); // Сортируем массивы
        Array.Sort(y);

        bool isEqual = Enumerable.SequenceEqual(x, y); // Сравниваем массивы между собой

        if (isEqual) return true;
        return false;
    }

    public void Print(bool str)
    {
        if (str) Console.WriteLine("Выражение 1 является перестановкой Выражения 2");
        else Console.WriteLine("Выражение 1 и Выражения 2 разные");
    }

}