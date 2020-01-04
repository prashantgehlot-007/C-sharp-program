using System;
class A
{
    public static void Main()
    {
        int f=1,n;
        Console.WriteLine("enter the value");
        n = int.Parse(Console.ReadLine());
        while (n>0)
        {
            f=f*n;
            n--;
        }
        Console.WriteLine("Factroria="+f);
    }
}