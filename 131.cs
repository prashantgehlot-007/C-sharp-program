// swaping two number
using System;
class A
{
    public void swap(int a,int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("after swaping no are="+a+"\t"+b);
    }
    public static void Main()
    {
        int a,b;
        A obj1 = new A();
        Console.WriteLine("Enter the value of a and b");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        obj1.swap(a,b);
    }
}
