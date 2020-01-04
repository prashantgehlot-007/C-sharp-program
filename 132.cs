// factoria using function with argument and return type
using System;
class B
{
    public int fact(int n)
    {
        int f=1,i;
        for(i=1;i<=n;i++)
        {
            f = f*i;
        }
        return(f);
    }
    public static void Main()
    {
        int a,b;
        B obj1 = new B();
        Console.WriteLine("enter the value");
        a = int.Parse(Console.ReadLine());
        b = obj1.fact(a);
        Console.WriteLine("factorial is="+b);
    }   
}