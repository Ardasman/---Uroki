// Алексей Астаапов
/*
4. *Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
<Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
*/

StreamReader sr = new StreamReader("/System/Volumes/Data/Диск D/С# Uroki/Urok5/Zadanie1(4)/Massv.txt");

int N = int.Parse(sr.ReadLine());

StructGrade[] a = new StructGrade[N];

for (int i = 0; i < N; i++)
{
    string[] s = sr.ReadLine().Split(' ');
    a[i].FIO = s[0] + " " + s[1];
    a[i].grade = int.Parse(s[2]);
    a[i].grade1 = int.Parse(s[3]);
    a[i].grade2 = int.Parse(s[4]);
}
sr.Close();

double[] midl = new double[N];

for (int i = 0; i < N; i++) // выесняем среднюю оценку
{
    midl[i] = (a[i].grade2 + a[i].grade1 + a[i].grade) / 3f;
}

double min = midl[0];
double min2 = midl[1];
double min3 = midl[2];

if (min2 < min) // выесняем какие средние меньшие
{
    min = min2;
    min2 = midl[0];
}
for (int i = 2; i < midl.Length; i++)
{
    if (min >= midl[i])
    {
        min2 = min;
        min = midl[i];
    }
    if (min2 >= midl[i] && midl[i] != min)
    {

        min2 = midl[i];
    }
    if (min3 >= midl[i] && midl[i] != min)
    {

        min3 = midl[i];
    }
}

for (int i = 0; i < N; i++)
{
    if (min == midl[i])
    {
        Console.WriteLine($"Успеваемость:  {a[i].FIO} - {min:F2}");
    }
    if (min2 == midl[i])
    {
        Console.WriteLine($"Успеваемость:  {a[i].FIO} - {min2:F2}");
    }
    if (min3 == midl[i])
    {
        Console.WriteLine($"Успеваемость:  {a[i].FIO} - {min3:F2}");
    }
}




