// Астапов Алексей г.Минск

            // 1. Программа "Анкета"

            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.


            Console.WriteLine(@"Введите необходимые данные для анкеты:
            Ваше имя: ");

            string name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия: ");

            string surname = Console.ReadLine();

            Console.WriteLine("Ваш возраст: ");

            string age = Console.ReadLine();

            Console.WriteLine("Ваш вес: ");

            string wight = Console.ReadLine();

            Console.WriteLine($@"{name}, проверьте ваши данные: 
                        Ваше имя: {name} 
                        Ваша фамилия: {surname} 
                        Ваш возраст: {age} 
                        Ваш вес: {wight}"); // в) Форматированный вывод с $

            Console.WriteLine("Ваши данные. Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Вес: " + wight); // a) Склейка

            Console.WriteLine("Ваши данные. Имя: {0} Фамилия: {1} Возраст: {2} Вес: {3}", name, surname, age, wight); // б) Форматированный вывод


            // 2. Программа "Индекс Массы тела"

            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ)
            //по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.


            Console.WriteLine("Для подсчета Индекса массы тела (ИМТ) необходимо указать ваш вес в кг, например 54.3 : ");

            string weightman = Console.ReadLine();

            double weight = Convert.ToDouble(weightman);

            Console.WriteLine("Так же необходимо указать ваш рост в метрах, например 1.72 :");

            string heightman = Console.ReadLine();

            double height = Convert.ToDouble(heightman);

            double imt = weight / Math.Pow(height, 2);

            Console.WriteLine($"Ваш интекс массы тела (ИМТ) равен: {imt:F2}");

            if (imt <= 19)
            {
                Console.WriteLine("У вас Недостаточная (дефицит) масса тела");
            }
            else if (imt <= 25 & imt >= 19)
            {
                Console.WriteLine("У вас ИМТ в норме");
            }
            else if (imt <= 30 & imt > 25)
            {
                Console.WriteLine("У вас избыточный вес");
            }
            else if (imt <= 35 & imt > 30)
            {
                Console.WriteLine("У вас ожирение 1 степени");
            }
            else if (imt <= 40 & imt > 35)
            {
                Console.WriteLine("У вас ожирение 2 степени");
            }
            else if (imt > 40)
            {
                Console.WriteLine("У вас ожирение 3 степени");
            }


            // 3. Программа "Растояние между точками с координатами"

            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


            Console.WriteLine("Введите значение координаты по x1: ");

            string x = Console.ReadLine();

            double x1 = Convert.ToDouble(x);

            Console.WriteLine("Введите значение координаты по y1: ");

            string y = Console.ReadLine();

            double y1 = Convert.ToDouble(y);

            Console.WriteLine("Введите значение координаты по x2: ");

            string xx = Console.ReadLine();

            double x2 = Convert.ToDouble(x);

            Console.WriteLine("Введите значение координаты по y2: ");

            string yy = Console.ReadLine();

            double y2 = Convert.ToDouble(yy);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Растояние между координатами x1y1 и x2y2: {r:F2}");


            // 4. Программа "Обмен значениями двух переменных"

            // Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

                        Console.WriteLine("Введите значение первой переменной: ");

            string prm1 = Console.ReadLine();

            int prmx = Convert.ToInt32(prm1);

            Console.WriteLine("Введите значение второй переменной: ");

            string prm2 = Console.ReadLine();

            int prmy = Convert.ToInt32(prm2);


            // через третью переменную

            int prm3;

            Console.WriteLine($"Значения переменых: первая переменная {prmx}, вторая переменная {prmy}");

            prm3 = prmy; // присваеваем третьей переменной значение второй
            prmy = prmx; // присваеваем второй переменной значение первой
            prmx = prm3; // присваеваем первой переменной значение второй


            Console.WriteLine($"Меняем значения переменых, теперь : первая переменная {prmx}, вторая переменная {prmy}");

            // без третьей переменной

            prmx = prmx + prmy - (prmy = prmx); // упращаем ряд действий (prmx = prmx + prmy) (prmy = prmx - prmy) (prmx = prmx - prmy)

            Console.WriteLine($"Меняем обратно значения переменых, теперь : первая переменная {prmx}, вторая переменная {prmy}");


            // 5. Вывод ФИО и города

            //Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организовать в центре экрана.
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            string family = "Астапов";
            string myname = "Алексей";
            string mysity = "Минск";

            Console.WriteLine($" Мое ФИО и город:  {family}, {myname}, {mysity}");

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

            Console.WriteLine($" Мое ФИО и город:  {family}, {myname}, {mysity}");
