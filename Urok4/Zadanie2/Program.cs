// Алексей Астаапов
/*
2. Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
*/

int[] Mass = StaticClass.Massive(20);      // создаем массив, указываем размеер
StaticClass.FillMass(Mass, -10000, 10000); // заполняем массив, указываем диапазон случайных чисел
string str = StaticClass.Show(Mass);
Console.WriteLine(str);
// File.WriteAllText("Massv.txt", str);   // записывае файл в массив
int para = StaticClass.ParaThree(Mass); // считаем пары чисел, в которых только одно число делится на 3
Console.WriteLine($" Количество пар: {para}");
string file = "/System/Volumes/Data/Диск D/С# Uroki/Urok4/Zadanie2/Massv.txt";
int[] FileMassnew = StaticClass.FileMass(file); // массив из файла
string str2 = StaticClass.Show(FileMassnew);
Console.WriteLine(str2);
