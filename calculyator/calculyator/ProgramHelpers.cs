/*internal static class ProgramHelpers : ProgramHelpersBase
{

    public override int SelectedCase(int id)
    {
        switch (id)
        {
            case 1:
                Console.WriteLine("Введите первое число для сложения:");

                int Num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число для сложения:");
                int Num2 = Convert.ToInt32(Console.ReadLine());

                int Count = Num1 + Num2;
                Console.WriteLine("Сумма данных чисел: + Count");


                Console.WriteLine("Введите выбранное действие");

                SelectedCase(Convert.ToInt32(Console.ReadLine()));
                break;

            case 2:

                Console.WriteLine("Введите первое число для вычитания:");

                Num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число для вычитания:");
                Num2 = Convert.ToInt32(Console.ReadLine());
                 Count = Num1 - Num2;
                Console.WriteLine("Ответ:");
                Console.WriteLine(Count);

                Console.WriteLine("Введите выбранное действие");

                SelectedCase(Convert.ToInt32(Console.ReadLine()));
                break;

            case 3:

                Console.WriteLine("Введите первое число для умножения:");

                Num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число для умножения:");
                Num2 = Convert.ToInt32(Console.ReadLine());

                Count = Num1 * Num2;
                Console.WriteLine("Ответ:");
                Console.WriteLine(Count);

                Console.WriteLine("Введите выбранное действие");

                SelectedCase(Convert.ToInt32(Console.ReadLine()));
                break;

            case 4:

                Console.WriteLine("Введите первое число для деления:");

                Num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число для деления:");
                Num2 = Convert.ToInt32(Console.ReadLine());

                Count = Num1 / Num2;
                Console.WriteLine("Ответ:");
                Console.WriteLine(Count);

                Console.WriteLine("Введите выбранное действие");

                SelectedCase(Convert.ToInt32(Console.ReadLine()));
                break;

            case 5:
                double a, b, c;
                Console.WriteLine("Введите первое число для возведения в степень:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число для степени:");
                b = Convert.ToInt32(Console.ReadLine());

                c = Math.Pow(a, b);

                Console.WriteLine("Ответ:");
                Console.WriteLine(c);

                Console.WriteLine("Введите выбранное действие");

                SelectedCase(Convert.ToInt32(Console.ReadLine()));
                break;
            case 6:

                double aa, cc;
                Console.WriteLine("Введите первое число для нахождения корня:");
                aa = Convert.ToInt32(Console.ReadLine());


                cc = Math.Sqrt(aa);

                Console.WriteLine("Ответа:");
                Console.WriteLine(cc);

                Console.WriteLine("Введите выбранное действие");

                SelectedCase(Convert.ToInt32(Console.ReadLine()));
                break;

            case 7:

                Console.WriteLine("Введите первое число для нахождения процента :");
                Num1 = Convert.ToInt32(Console.ReadLine());

                Count = Num1 / 100;

                Console.WriteLine("Ответ:");
                Console.WriteLine(Count);

                Console.WriteLine("Введите выбранное действие");

                SelectedCase(Convert.ToInt32(Console.ReadLine()));
                break;

            case 8:

                Console.WriteLine("Введите первое число для нахождения факториала:");
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                {
                    if (n == 1) return;

                    return n * (n - 1);
                }
                break;

            case 9:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Такой операции нет!");
                break;
        }
    }
} */