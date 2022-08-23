// void Palindrom(int n)
// {
//     if (n < 9999 || n > 99999)
//     {
//         Console.WriteLine (" число не пятизначное");  //проверяем на пятизначность число
//     }
//     if ((n / 1000) == n% 10 *10 + (n%100/10)) // отделяеи от числа первые 2 цифры, сравниваем, с перевернутыми 2-мя числами с конца
    
//         Console.WriteLine("палиндром");
    
//     else
    
//         Console.WriteLine("нет");
    


// }


// Console.WriteLine ("Введите пятизанчное число");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindrom(num);  // испрльзуем наш метод




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void coub(int N)
// {
//     int i = 1;
    
//     while(i <= N)
//     {
//         Console.Write($"{Math.Pow(i,3)}");
//         i++;

//     }

// }
// Console.WriteLine ("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// coub(N);
 


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// формула АВ=√(x2-x1)^2+(y2-y1)^2+(z2-z1)



double point( double x1, double x2, double y1, double y2, double z1, double z2)
{
    double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return AB;
}

Console.WriteLine ("Введите координату Х1: ");
double Xa= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату Х2: ");
double Xb= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату Y1: ");
double Ya= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату Y2: ");
double Yb= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату Z1: ");
double Za= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату Z2: ");
double Zb= Convert.ToInt32(Console.ReadLine());

double otr = point(Xa, Ya, Za, Xb, Yb,Zb);
Console.WriteLine($"Расстояние между точками в 3D пространстве = {otr}");