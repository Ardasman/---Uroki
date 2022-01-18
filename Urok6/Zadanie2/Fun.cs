using System.IO;
public delegate double Funkts(double x);

public class Fun
{
    // Функции

    public static double myFun1(double x) //  первая функция
    {
        return x * x - 50 * x + 10;       //  f(x)=y*y-50*y+10
    }

    public static double myFun2(double x) //  функция возвидения в квадрат
    {
        return x * x * x;                     // f(x) = y^3
    }

    public static double myFun3(double x)     //  функция возвидения в квадрат
    {
        return Math.Sin(x);                   // f(x) = Sin(y)
    }

    // Расчёт значения функции и запись в файл двоичным потоком
    // "fileName" - имя файла (путь к нему)
    // "start" - начальное значение промежутка функции
    // "end" - конечное значение промежутка функции
    // "step" - Шаг промежутка 
    // "F" - Делегат функции

    public static void SaveFunc(string fileName, double start, double end, double step, Funkts F)
    {
        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        double x = start;
        while (x <= end)
        {
            bw.Write(F(x));
            x += step;
        }
        bw.Close();
        fs.Close();
    }

    // Возвращаем массив считанных значений. Возвращаем минимум через параметр out.

    public static double[] Load(string fileName, out double min)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);

        double[] mass = new double[fs.Length / sizeof(double)];
        min = double.MaxValue;

        for (int i = 0; i < fs.Length / sizeof(double); i++)
        {
            mass[i] = bw.ReadDouble();
            if (mass[i] < min) min = mass[i];
        }
        bw.Close();
        fs.Close();
        return mass;
    }

    // защита ввода и получение значений выбора и переменной

    public static double GetNum(string txt)
    {
        double result;
        bool flag = false;
        do
        {
            flag = double.TryParse(txt, out result);
        } while (!flag);

        return result;
    }

    public static void Print(string txt) { Console.Write(txt); }

    public static void ShowFun(string VF, double r)
    {
        string a = VF;
        Console.WriteLine("Результат: " + a + r);
    }
}