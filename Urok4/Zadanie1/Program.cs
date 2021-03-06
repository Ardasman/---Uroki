// Алексей Амтапов
/*1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
В данной задаче под парой подразумевается два подряд идущих элемента массива.
Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. */

Massiv a = new Massiv();
int[] Mass = a.Massive(20);      // создаем массив, указываем размеер
a.FillMass(Mass, -10000, 10000); // заполняем массив, указываем диапазон случайных чисел
string str = a.Show(Mass);
Console.WriteLine(str);
int para = a.ParaThree(Mass); // считаем пары чисел, в которых только одно число делится на 3
Console.WriteLine($" Количество пар: {para}");