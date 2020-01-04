// array using buuble sort
using System;
class A
{
    public static void Main()
    {
        int []a = new int[10];
        int i,j,temp;
        for(i=0;i<10;i++)
    {
        Console.WriteLine("enter element of array");
        a[i] = int.Parse(Console.ReadLine());
    }
   
    for(i=0;i<10;i++)
    {
        for(j=0;j<9;j++)
        {
            if(a[j]>a[j+1])
            {
                temp = a[j];
                a[j] = a[j+1];
                a[j+1] = temp;
            }
        }
    }
     for(i=0;i<10;i++)
    {
        Console.WriteLine("sorted array"+a[i]+" ");
    }
    
    }
}