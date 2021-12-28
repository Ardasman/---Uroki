int[] Mass = StaticClass.Massive(20);      // создаем массив, указываем размеер
StaticClass.FillMass(Mass, -10000, 10000); // заполняем массив, указываем диапазон случайных чисел
string str = StaticClass.Show(Mass);
Console.WriteLine(str);
// File.WriteAllText("Massv.txt", str);   // сзаписывае файл в массив
int para = StaticClass.ParaThree(Mass); // считаем пары чисел, в которых только одно число делится на 3
Console.WriteLine($" Количество пар: {para}");
