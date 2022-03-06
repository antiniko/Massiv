// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int X(int num)
{
    if (num < 100)
    {
        Console.WriteLine("нету третьей цифры");
        return num;
    }
    else if (num > 999)
    {
        Console.WriteLine("Слишком много цифр");
        return num;        
    }
    else
    {
    int n1 = num / 100;
    int n2 = (num / 10) - (n1 * 10);
    int n3 = num - (n1 * 100 +n2 * 10);
    return n3;
    }
}

Console.WriteLine("Write nuber from 100 to 999");
int number = Convert.ToInt32(Console.ReadLine());
X(number);
Console.Write("Third nuber is: ");
Console.Write(X(number));

//к сожалению не получается пока что сделать так, что бы выводил только одну строку.
