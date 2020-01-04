// count number of digit by a user
using System;
class a
{
    public static void Main()
    {
        long n;
        int i=0;
        Console.WriteLine("enter the value of n");
        n = long.Parse(Console.ReadLine());
        while (n!=0)
        {
            n=n/10;
            i++;
        }
        Console.WriteLine("value of i ="+i);

    }
}
