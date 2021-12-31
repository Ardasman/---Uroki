/* Астапов Алексей

3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например: badc являются перестановкой abcd.
*/

Str ab = new Str();

System.Console.WriteLine("Введите выражение 1: ");
string a = Console.ReadLine();
System.Console.WriteLine("Введите выражение 2: ");
string b = Console.ReadLine();

bool pr = ab.Sravn(a, b);

ab.Print(pr);
ab.Print(pr);