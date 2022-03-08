// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
void den(int num)
{
    if(num < 6 )
    {
    Console.WriteLine("Working day");   
    }
    else if(num > 7)
    {
    Console.WriteLine("read the requirements");
    }
    else 
    {
    Console.WriteLine("Weekend");
    }
}
Console.WriteLine("Write nuber from 1 to 7");
int number =
 Convert.ToInt32(Console.ReadLine());
den(number);

//моя пока большая проблема, неполучается оформит формулу с $$ 
//пример if(num > 2 && num < 5) не воспринимает (
*/

// а вот через case заработало красиво
// при повторном открытии начал выделять void но работает :)
void week(int DenNedeli)
{
    switch(DenNedeli)
    {
        case 1:
        {
        Console.WriteLine("Рабочий день");
        break;
        }
        case 2:
        {
        Console.WriteLine("Рабочий день");
        break;
        }
        case 3:
        {
        Console.WriteLine("Рабочий день");
        break;
        }
        case 4:
        {
        Console.WriteLine("Рабочий день");
        break;
        }
        case 5:
        {
        Console.WriteLine("Рабочий день");
        break;
        }
        case 6:
        {
        Console.WriteLine("Выходной");
        break;
        }
        case 7:
        {
        Console.WriteLine("Выходной");
        break;
        }
        default:
        {
        Console.WriteLine("Нет такого дня недели.");
        break;
        }
    }
}
int den;
Console.WriteLine("input den(1-7): ");
den = Convert.ToInt32(Console.ReadLine());
week(den);
