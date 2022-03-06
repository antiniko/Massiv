// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
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

