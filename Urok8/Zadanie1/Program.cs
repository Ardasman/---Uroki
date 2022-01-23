// Астапов Алексей
// С помощью рефлексии выведите все свойства структуры DateTime

using System;
using System.Reflection;


Type t = typeof(DateTime);
foreach (var prop in t.GetProperties())
    Console.WriteLine(prop.Name);
