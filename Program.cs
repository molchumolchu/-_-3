int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

void Task19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    // 14212 -> нет. 12821 -> да. 23432 -> да

    int num = Input("введите число: "); // 12821
    int num1= num/1000; //12
    int num2=num%100; //21
    if (num1/10 == num2%10 && num1%10 == num2/10) // 12/10 == 21%10 & 12%10==21/10 => 1 == 1 & 2==2
    {
        Console.WriteLine($"число {num} является полиндромом");
    }

    else
    {
        Console.WriteLine($"Число {num} не является полиндромом");
    }
    
}


void Task21()
{
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
    int x1 = Input("Введите X точки А ") ;
    int y1 = Input("Введите Y точки А ");
    int z1 = Input("Введите Z точки А ");
    int x2 = Input("Введите X точки B ") ;
    int y2 = Input("Введите Y точки B ");
    int z2 = Input("Введите Z точки B ");
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)); //Math.Sqrt - возвращает квадратный корень Math.Pow - число в сепень (число, степень)
    result = Math.Round(result, 2); // округление до сотых

    Console.WriteLine($"Расстояние между точками: {result}");
}


void Task23_1()
{
//     Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
    int number = Input("Введите число N ");
    int count = 1;
    while (count<=number)
    {
        Console.WriteLine($"{count}^3 = {Math.Pow(count, 3)}, ");
        count++;
    }  
        Console.WriteLine();
}


void Task23_2()
{
//     Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
    int number = Input("Введите число N ");
    for (int i = 1; i<=number; i++)
    {
        Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}, ");
    }  
}





// Дополнительные задачи

void Task2()
{
    //Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
    int num = Input("Введите трехзначное число N ");
    int sum = 0;
    sum = num / 100 + (num / 10)%10 + num%10;
    if (sum%3 == 0)
    {
        Console.WriteLine($" Число {num} кратно трём");  
    }
    else
    {
        Console.WriteLine($" Число {num} не кратно трём");  
    }
}



void Task3()
{
    //Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
    int num = Input("Введите трехзначное число N ");
    int num1 = num / 100;
    int num2 = (num / 10)%10;
    int num3 = num%10;
    if (num1 == 4 || num2 == 4 || num3 == 4 || num1 == 7 || num2 == 7 || num3 == 7)
    {
        Console.WriteLine($"В числе {num} есть цифра 4 или 7");
    }
   
    else
    {
        Console.WriteLine($"В числе {num} нет цифр 4 или 7");  
    }
}


void Task4()
//Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
{
    int size=10; // размер массива
    int []numbers=new int[size]; // создали массив
    for (int i=0; i<size; i++) //заполнили
    {
        numbers[i]=i+1;
        Console.Write($"{numbers[i]} ");
        
    }
    Console.WriteLine();
}

void Task1_1()
//Задача 1. На ввод подаётся номер четверти. 
// Создаются 3 случайные точки в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
{
    /// Т.к. все точки лежат в одной четверти, то нам без разницы в какой именно, 
    // Так как каждая точка А будет равно удалена от центра координат и от точек В и С соответственно. В любом случае каждая точка возводиться в квадрат.
    // Поэтому можно считать все по модулю, как будто все точки в 1 четверти.

    Random rnd = new Random();
    int x1 = rnd.Next();
    int x2 = rnd.Next();
    int x3 = rnd.Next();
    int y1 = rnd.Next();
    int y2 = rnd.Next();
    int y3 = rnd.Next();
    int y0 =0;
    int x0=0;
    
    //Выводим расположение точек в зависимости от четверти
    int quater = Input("Введите номер четверти ");
    if (quater <0 || quater>4)
    {
        Console.WriteLine("Такой четверти не существует");
    }
    else if (quater == 1)
    {
        Console.WriteLine($"Координаты точек A ({x1}, {y1}), B ({x2}; {y2}); C ({x1}; {y3})");
    }
    else if (quater == 2)
    {
        Console.WriteLine($"Координаты точек A (-{x1}, {y1}), B (-{x2}; {y2}); C (-{x1}; {y3})");
    }
        else if (quater == 3)
    {
        Console.WriteLine($"Координаты точек A (-{x1}, -{y1}), B (-{x2}; -{y2}); C (-{x1}; -{y3})");
    }
    else if (quater == 4)
    {
        Console.WriteLine($"Координаты точек A ({x1}, -{y1}), B ({x2}; -{y2}); C ({x1}; -{y3})");
    }

    // посчитаем расстоение между всеми точками: 
    // от центра до каждой точки
    // от А до В, потом от А до С, от В до С
    double dist0A = Math.Sqrt(Math.Pow((x1-x0), 2) + Math.Pow((y1-y0), 2));
    dist0A = Math.Round(dist0A, 0);
    double dist0B = Math.Sqrt(Math.Pow((x2-x0), 2) + Math.Pow((y2-y0), 2));
    dist0B = Math.Round(dist0B, 0);
    double dist0C = Math.Sqrt(Math.Pow((x3-x0), 2) + Math.Pow((y3-y0), 2));
    dist0C = Math.Round(dist0C, 0);
    double distAB = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2));
    distAB = Math.Round(distAB, 0);
    double distAC = Math.Sqrt(Math.Pow((x1-x3), 2) + Math.Pow((y1-y3), 2));
    distAC = Math.Round(distAC, 0);
    double distBC = Math.Sqrt(Math.Pow((x2-x3), 2) + Math.Pow((y2-y3), 2));
    distBC = Math.Round(distBC, 0);
    
    //теперь посчитаем маршрут // очень хотелось бы оптимизировать и сделать через цикл while но не придумала как
    double sum1 = dist0A+distAB+distBC;
    double min = sum1;
    double sum2 = dist0A+distAC+distBC;
    double sum3 = dist0B+distAB+distAC;
    double sum4 = dist0B+distBC+distAC;
    double sum5 = dist0C+distAC+distAB;
    double sum6 = dist0C+distBC+distAB;
    
    if (sum1 < sum2 && sum1 <sum3 && sum1<sum4 && sum1<sum5 && sum1<sum6)
    {
        min = min;
        min = Math.Round(min, 0);
        Console.WriteLine($"Кратчайший маршрут: центр координат-> А -> B -> C составляет {sum1}");
    }
    else if (sum2 < sum1 && sum2 <sum3 && sum2<sum4 && sum2<sum5 && sum2<sum6)
    {
        min = sum2;
        min = Math.Round(min, 0);
        Console.WriteLine($"Кратчайший маршрут: центр координат-> A -> C -> B составляет {sum2}");
    }
    else if (sum3 <sum1 && sum3 < sum2  && sum3 <sum4 && sum3<sum5 && sum3<sum6)
    {
        min = sum3;
        min = Math.Round(min, 0);
        Console.WriteLine($"Кратчайший маршрут: центр координат-> B -> A -> C составляет {sum3}");
    }
    else if (sum4 <sum1 && sum4 < sum2  && sum4 <sum3 && sum4<sum5 && sum4<sum6)
    {
        min = sum4;
        min = Math.Round(min, 0);
        Console.WriteLine($"Кратчайший маршрут: центр координат-> B -> C -> A составляет {sum4}");
    }
    else if (sum5 <sum1 && sum5 < sum2  && sum5 <sum3 && sum5<sum4 && sum5<sum6)
    {
        min = sum5;
        min = Math.Round(min, 0);
        Console.WriteLine($"Кратчайший маршрут: центр координат-> C -> A -> B составляет {sum5}");
    }
    else if (sum6 <sum1 && sum6 < sum2  && sum6 <sum3 && sum6<sum4 && sum6<sum5)
    {
        min = sum6;
        min = Math.Round(min, 0);
        Console.WriteLine($"Кратчайший маршрут: центр координат-> C -> A -> B составляет {sum6}");
    }



}
Task1_1();