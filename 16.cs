// check prime or not
using System;
class A
{
    public static void Main()
    {
        int i,n,f=0;
        Console.WriteLine("enter the value of n");
        n = int.Parse(Console.ReadLine());
        for(i=2;i<n;i++)
        {
            if(n%i==0)
            {
                Console.WriteLine("num is not prime");
                f = 1;
                break;
            }
        }
        if(f == 0)
        {
               Console.WriteLine("prime");
        }
        
    }
}