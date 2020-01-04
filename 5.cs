using System;
class A
{
    public static void Main()
    {
        int []a = new int[5];
        int []b = new int[5];
        int []c = new int[5];
        int i,sum = 0,max,min;
        Console.WriteLine("enter the value of array a");
        for(i=0;i<5;i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter the value of array b");
        for(i=0;i<5;i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }
        for(i=0;i<5;i++)
        {
            c[i] = a[i] + b[i];
        }

        for(i=0;i<5;i++)
        {
            Console.Write(a[i]+"");
        }
        for(i=0;i<5;i++)
        {
            sum = sum + a[i];
        }
        Console.Write("\nsum of elemet of array is :-"+sum);
        min = a[0];
        max = a[0];
        for(i=0;i<5;i++)
        {
            if(a[i]>max)
            {
                max = a[i];
            }
            if(a[i]<min)
            {
                min = a[i];
            }
        }
        Console.WriteLine("maximum no is\t"+max+"\nminimum no is\t"+min);
        for(i=0;i<5;i++)
        {
            Console.Write(c[i]+"\t");
        }
    
    }
}