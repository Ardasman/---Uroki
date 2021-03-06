using System.IO;
static class StaticClass
{
    public static int[] Massive(int n) // конструктор массива
    {
        int[] nums = new int[n];
        return nums;
    }
    public static string Show(int[] num) // метод вывода в консоль
    {
        string outnums = String.Empty;
        for (int i = 0; i < num.Length; i++)
        {
            outnums += $"Эллемент {i} = {num[i]}\n";
        }
        return outnums;
    }
    public static void FillMass(int[] num, int min, int max) // метод заполнения массива случайными цифрами в заданом диапазоне
    {
        Random rnd = new Random();
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = rnd.Next(min, max);
        }
    }
    public static int ParaThree(int[] num) // считаем пары чисел, в которых только одно число делится на 3
    {
        int count = 0; // счёчик пар
        for (int i = 0; i < num.Length - 1;)
        {
            int a = num[i] % 3;
            int b = num[++i] % 3;
            if (a == 0 ^ b == 0) count++;
        }
        return count;
    }
    public static int[] FileMass(string filename) // читаем файл и записываем в массив
    {
        int[] a = new int[20];
        StreamReader sr = new StreamReader(filename);

        for (int i = 0; i < 20; i++)
        {
            a[i] = int.Parse(sr.ReadLine());
        }
        sr.Close();
        return a;
    }
}