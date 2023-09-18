using System.Numerics;

    internal class Program
    {
        public static int Num1;
        public static int Num2;
        public static int Count;
    private static int n;

    static void Main(string[] args)
        {


            Console.WriteLine("1 - Сложить 2 числа");
            Console.WriteLine("2 - Вычесть превое из второго");
            Console.WriteLine("3 - Перемножить два числа");
            Console.WriteLine("4 - Разделить первое число на второе");
            Console.WriteLine("5 - Возвести в степень n первое число");
            Console.WriteLine("6 - Найти квадратный корень из числа");
            Console.WriteLine("7 - Найти 1 процент от числа");
            Console.WriteLine("8 - Найти факториал от числа");
            Console.WriteLine("9 - EXIT");
            Console.WriteLine("Выберете действие");

            SelectedCase(Convert.ToInt32(Console.ReadLine()));

        }

        public static void SelectedCase(int id)
        {
            switch (id)
            {
                case 1:
                    int aads, baf, cdhgd;
                    Console.WriteLine("Введите первое число для сложения:");

                    aads = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число для сложения:");
                    baf = Convert.ToInt32(Console.ReadLine());

                    cdhgd = aads + baf;
                    Console.WriteLine("Сумма данных чисел: " + cdhgd);


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

                    double aa, bb;
                    Console.WriteLine("Введите первое число для нахождения корня:");
                    aa = Convert.ToInt32(Console.ReadLine());


                    bb = Math.Sqrt(aa);

                    Console.WriteLine("Ответа:");
                    Console.WriteLine(bb);

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

                    Console.WriteLine("Введите первое число для нахождения факториала :");
                    Num1 = Convert.ToInt32(Console.ReadLine());

                    
                    Console.WriteLine("Отвте: ");
                    Factarial(Num1);
                    
                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

            case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

    static BigInteger Factarial(int i)
    {
        var FactarialA = new BigInteger(i);
        for (int n = 1; n < i; n++)
        {
            FactarialA *= n;
        }
        Console.WriteLine("Ответ факториал " + FactarialA);
        return FactarialA;

    }
}


            

                    

        
    
