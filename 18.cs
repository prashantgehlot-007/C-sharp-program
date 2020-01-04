// print table of given num
using System;
class A
{
    public static void Main()
    {
        int a,i;
        Console.WriteLine("enter the value of a");
        a = int.Parse(Console.ReadLine());
        for(i=1;i<=10;i++)
       {
        Console.WriteLine(" "+a+" X "+i+"= "+a*i);
       }
    }
}