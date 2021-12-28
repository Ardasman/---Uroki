
Massiv a = new Massiv();
int[] Mass = a.Massive(20);      // создаем массив, указываем размеер
a.FillMass(Mass, -10000, 10000); // заполняем массив, указываем диапазон случайных чисел
string str = a.Show(Mass);
Console.WriteLine(str);
int para = a.ParaThree(Mass); // считаем пары чисел, в которых только одно число делится на 3
Console.WriteLine($" Количество пар: {para}");