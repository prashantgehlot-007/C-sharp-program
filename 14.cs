// inseration of element in an array
using System;
class A
{
    public static void Main()
    {
        int []a = new int[50];
        int i,n,key,loc;
        Console.WriteLine("enter the size of array");
        n= int.Parse(Console.ReadLine());
        for(i=0;i<n;i++)
        {
            Console.WriteLine("enter array element");
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter element to be insert:-");
        key = int.Parse(Console.ReadLine());
        Console.WriteLine("enter location of insert");
        loc = int.Parse(Console.ReadLine());
        for(i=n-1;i>=loc;i--)
        {
            a[i+1] = a[i];
        }
        a[loc] = key;
        Console.WriteLine("output array is :-");
        for(i=0;i<n;i++)
        {
            Console.Write(a[i]+" ");
        }
    }
}