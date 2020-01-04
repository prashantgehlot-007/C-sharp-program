using System;
class A
{
    public int sum(int a,int b)
    {
        int c;
        c = a+b;
        return (c);
    }
    public static void Main()
    {
        int a,b,s;
        A obj1 = new A();
        Console.WriteLine("enter value of a and b");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        s = obj1.sum(a,b);
        Console.WriteLine("sum="+s);
    }
}