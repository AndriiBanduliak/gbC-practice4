/*Задача 25:**Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16*/
using static System.Console;
WriteLine("Enter the number A and the number B");
int a=getIngeger(); 
int b=getIngeger();
WriteLine($"The number A={a} to the power of B={b} is: {pow(a,b)}");

int getIngeger()
{
    ///Write("Enter the number: ");
    return int.Parse(ReadLine());
}
int pow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}