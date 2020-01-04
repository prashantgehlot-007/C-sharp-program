// check a three digit no is palindrome or not
using System;
class S
{
    public static void Main()
    {
        int n,a,b;
        Console.WriteLine("enter the value of n");
        n= int.Parse(Console.ReadLine());
        a=n%10;
        b=n/100;

        if(a==b)
        {
            Console.WriteLine("amstrong");
        }
        else
        {
            Console.WriteLine("not amstrong");
        }
    }
}