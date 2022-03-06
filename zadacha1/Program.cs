//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int X(int num)
{
    int n1 = num / 100;
    int n2 = (num / 10) - (n1 * 10);
    int n3 = num - (n1 * 100 +n2 * 10);
    return n2;
    
}
//если вворить значение вручную
Console.WriteLine("Write nuber from 100 to 999");
int number = Convert.ToInt32(Console.ReadLine());
X(number);
Console.Write("Second nuber is: ");
Console.Write(X(number));

/*
// через генератор
int number = new Random().Next(100,999);
X(number);
Console.WriteLine(number);
Console.Write("second nember is: ");
Console.Write(X(number));
*/