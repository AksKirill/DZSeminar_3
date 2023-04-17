// Задача 19 - программа, проверяет 5-значное число на полиндромность
Console.WriteLine("введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

string b=Convert.ToString(a);
// Console.WriteLine(b);
// Console.WriteLine(b.Length);
 int c=Convert.ToInt32(b.Length);
 Console.WriteLine(c);
if (b.Length==5 && b[1]==b[3] && b[0]==b[4])
    {
        Console.WriteLine("число полиндром");   
    }
else if (c<5 || c>5) 
    {
        Console.WriteLine("число не пятизначное");  
    }
else 
    {
        Console.WriteLine("число не полиндром");  
    }

// //////////////////////////////////////////////////////////////
// // Задача 21 - Программа по трем точкам в пространстве раасчитывает расстояние между ними

// Console.WriteLine("введите координату x1: ");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату y1: ");
// int y1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату z1: ");
// int z1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координату x2: ");
// int x2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату y2: ");
// int y2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату z2: ");
// int z2=Convert.ToInt32(Console.ReadLine());

// double d=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));
//   Console.WriteLine("расстояние между точками: " +Math.Round(d,2));

// ////////////////////////////////////////////////////////////
// //Задача 23 - программа на вход получает число N и в ответ выдает кубы чисел от 1 до N

// Console.WriteLine("введите число: ");
// int N=Convert.ToInt32(Console.ReadLine());


// for (int i=1;i<=N;i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }






