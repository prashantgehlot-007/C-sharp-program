// check amstrong or not
using System;
class A
{
    public static void Main()
    {
        int n,a,b,sum=0;
        Console.WriteLine("enter the value of n");
        n = int.Parse(Console.ReadLine());
        b=n;
        while(n>0)
        {
            a = n%10;
            sum = a*a*a + sum;
            n = n/10;
        }
        if(b==sum)
        {
            Console.WriteLine("amstrong");
        }
        else
        {
            Console.WriteLine("not amstrong");
        }
    }
}