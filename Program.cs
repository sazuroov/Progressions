Console.WriteLine("Алгебраическая - a // Геометрическая - g");

string choose = Convert.ToString(Console.ReadLine());

if (choose == "a")
{
    Console.WriteLine("Введите первое число арифметической прогрессии");

    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите шаг арифметической прогрессии");

    int step = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите конечное значение");

    int times = Convert.ToInt32(Console.ReadLine());

    int nextNum = n;

    int res = n;

    for (int i = 0; i < times - 1; i++)
    {
        nextNum = nextNum + step;
        res = res + nextNum;
    }

    Console.WriteLine(res);

}

else if (choose == "g")
{
    Console.WriteLine("Введите изначальное значение:");

    double startN = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите знаменатель:");

    double stepOne = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите конечное значение:");

    double last = Convert.ToDouble(Console.ReadLine());

    double sum = startN * (Math.Pow(stepOne, last) / stepOne - 1);

    Console.WriteLine($"Сумма прогрессии {sum}");
}




/*Console.WriteLine("Введите первое число арифметической прогрессии");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите шаг арифметической прогрессии");

int step = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное количество");

int times = Convert.ToInt32(Console.ReadLine());

int nextNum = n;

int res = n;

for (int i = 0; i < times - 1; i++)
{
    nextNum = nextNum + step;
    res = res + nextNum;
}

Console.WriteLine(res);*/
