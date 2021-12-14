// Астапов Алексей

            // 1. Написать метод, возвращающий минимальное из трёх чисел.


            Console.WriteLine("Введите первое число: ");

            int onenumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число, которое отличается от первого: ");

            int twonumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число, которое отличается от первых двух: ");

            int threenumber = Int32.Parse(Console.ReadLine());


            if (onenumber < twonumber & onenumber < threenumber)
            {
                Console.WriteLine($"Первое введенное Вами число:  {onenumber} - наменьшое их трех");
            }

            else if (twonumber < onenumber & twonumber < threenumber)
            {
                Console.WriteLine($"Второе введенное Вами число:  {twonumber} - наменьшое их трех");
            }

            else
            {
                Console.WriteLine($"Третье введенное Вами число:  {threenumber} - наменьшое их трех");
            }

            // 2. Написать метод подсчета количества цифр числа.

            Console.WriteLine("Введите число: ");

            string numbertxt = Console.ReadLine();

            int number;

            for (number = 0; numbertxt.Length > number;)
            {
                number++;
            }

            Console.WriteLine($"Количества цифр числа:  {number}");


            // 3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.


            int numbers = Int32.Parse(Console.ReadLine());
            int nechet = 0;                                        // переменная подсчета суммы нечетных положительных чисел

            while (numbers != 0)
            {

                if (numbers % 2 > 0)                                 // проверка остатка при делении на 2
                {
                    nechet += numbers;
                }

                numbers = Int32.Parse(Console.ReadLine());
            }

            if (nechet == 0)
            {
                Console.WriteLine("Вы не ввели ни одного положительного нечетного числа");
            }

            else
            {
                Console.WriteLine($"Сумму всех нечетных положительных чисел:  {nechet}");
            }


            // 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            // Используя метод проверки логина и пароля, написать программу:
            // пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            // С помощью цикла do while ограничить ввод пароля тремя попытками.

            string login = "root";
            string password = "GeekBrains";
            string checklogin;
            string checkpassword;
            int k = 0;

            do
             {
               
                Console.WriteLine("Чтобы авторезироваться введите ваш логин и пароль:\nLogin: ");

                checklogin = Console.ReadLine();

                Console.WriteLine("Password: ");

                checkpassword = Console.ReadLine();

                k++;

                if (login == checklogin | password == checkpassword)
                {
                    Console.WriteLine("Вы успешно авторезировались");
                    break;
                }

                if (k == 3)
                {
                    Console.WriteLine("Вы привысили число попыток ввода логина и пароля");
                    break;
                }
            }

            while (login != checklogin | password != checkpassword);

            // 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет 
            // его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //            
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            // 5. а)

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

            // 5. б)

            double normweight = Math.Pow(height, 2)* 27.5;

            if (normweight < weight)
            {

                double advnormweight = weight - normweight;
                Console.WriteLine($"Вам необходимо похудеть на {advnormweight} кг");

            }
            else
            {
                double advnormweight = normweight - weight;
                Console.WriteLine($"Вам необходимо набрать {advnormweight} кг");
            }