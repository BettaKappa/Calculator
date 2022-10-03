// Прога делает всё, что вы просилси (вроде)
// Я добавила проверку на тип переменной, на деление на ноль и ещё пару моментов
// Вероятно, это можно было сделать и меньшим кол-вом строк, но я вижу с# первый раз в жизни
while (true)
{

    Console.WriteLine("\n\n   Выберите действие из предложенного списка и введите соответсвующую ему цифру: \n" +
                  "1. Сложить 2 числа\n" +
                  "2. Вычесть первое из второго\n" +
                  "3. Перемножить два числа\n" +
                  "4. Разделить первое на второе\n" +
                  "5. Возвести в степень N первое число\n" +
                  "6. Найти квадратный корень из числа\n" +
                  "7. Найти 1 процент от числа\n" +
                  "8. Найти факториал из числа\n" +
                  "9. Выйти из программы");
    Console.WriteLine("\nВведите номер действия:");
    string a = Console.ReadLine();
    double answer;
    double n;
    if (int.TryParse(a, out _))
    {
        int action = Convert.ToInt32(a);
        if (action == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите первое слагаемое");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("Введите второе слагаемое");
                string num2 = Console.ReadLine();
                if (double.TryParse(num2, out n))
                {
                    Console.WriteLine("\n\nОтвет:");
                    double intnum1 = Convert.ToDouble(num1);
                    double intnum2 = Convert.ToDouble(num2);
                    answer = intnum1 + intnum2;
                    Console.WriteLine(answer);
                }
                else
                {
                    Console.WriteLine("\n\n Ошибка");
                }
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
            }
        }
        if (action == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите уменьшаемое");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("Введите вычитаемое");
                string num2 = Console.ReadLine();
                if (double.TryParse(num2, out n))
                {
                    Console.WriteLine("\n\nОтвет:");
                    double intnum1 = Convert.ToDouble(num1);
                    double intnum2 = Convert.ToDouble(num2);
                    answer = intnum1 - intnum2;
                    Console.WriteLine(answer);
                }
                else
                {
                    Console.WriteLine("\n\n Ошибка");
                }
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
            }
        }
        if (action == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите первый множитель");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("Введите второй множитель");
                string num2 = Console.ReadLine();
                if (double.TryParse(num2, out n))
                {
                    Console.WriteLine("\n\nОтвет:");
                    double intnum1 = Convert.ToDouble(num1);
                    double intnum2 = Convert.ToDouble(num2);
                    answer = intnum1 * intnum2;
                    Console.WriteLine(answer);
                    break;
                }
                else
                {
                    Console.WriteLine("\n\n Ошибка");
                }
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
                break;
            }
        }
        if (action == 4)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите делимое");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("Введите делитель");
                string num2 = Console.ReadLine();
                if (double.TryParse(num2, out n))
                {
                    double intnum1 = Convert.ToDouble(num1);
                    double intnum2 = Convert.ToDouble(num2);
                    if (intnum2 != 0)
                    {
                        answer = intnum1 / intnum2;
                        Console.WriteLine("\n\nОтвет:");
                        Console.WriteLine(answer);
                    }
                    else
                    {
                        Console.WriteLine("\n\n Ошибка");
                        Console.WriteLine(" На ноль делить нельзя");
                    }
                }
                else
                {
                    Console.WriteLine("\n\n Ошибка");
                }
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
            }
        }
        if (action == 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите число");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("Введите степнь, в которую хотите возвести это число");
                string num2 = Console.ReadLine();
                if (double.TryParse(num2, out n))
                {
                    Console.WriteLine("\n\nОтвет:");
                    double intnum1 = Convert.ToDouble(num1);
                    double intnum2 = Convert.ToDouble(num2);
                    answer = Math.Pow(intnum1, intnum2);
                    Console.WriteLine(answer);
                }
                else
                {
                    Console.WriteLine("\n\n Ошибка");
                }
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
            }
        }
        if (action == 6)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите число");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("\n\nОтвет:");
                double intnum1 = Convert.ToDouble(num1);
                answer = Math.Sqrt(intnum1);
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
            }
        }
        if (action == 7)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите число");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("\n\nОтвет:");
                double intnum1 = Convert.ToDouble(num1);
                answer = intnum1 * 0.01;
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
            }
        }
        if (action == 8)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите число");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out n))
            {
                Console.WriteLine("\n\nОтвет:");
                double intnum1 = Convert.ToDouble(num1);
                double factorial = 1;
                for (int i = 2; i <= intnum1; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
            else
            {
                Console.WriteLine("\n\n Ошибка");
            }
        }
        if (action == 9)
        {
            Console.WriteLine("\n\n    Вы вышли из программы\n\n");
            Environment.Exit(0);
        }
    }
    else
    {
        Console.WriteLine("\nОшибка\n\n");

    }
}

// Ладно, на самом деле мне сейчас просто лень в этом разбираться. Главное, что она работает так, как я хочу))
// P.S. Хорошего вам дня :]