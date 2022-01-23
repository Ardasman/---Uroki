// Алексей Астапов
// 5. **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).

Converter a = new Converter();

Console.WriteLine("Преобразовываем CSV файл в XML-файл");

a.Convert("/System/Volumes/Data/Диск D/С# Uroki/Urok8/Zadanie2/student.csv", "/System/Volumes/Data/Диск D/С# Uroki/Urok8/Zadanie2/students.xml");

Console.WriteLine("Преобразовывание завершено");
