using System;
class A
{
    public static void Main()
    {
        int i,j,r,c;
        Console.WriteLine("enter the value of row");
        r = int.Parse(Console.ReadLine());
        int [][]a = new int[r][];
        for(i=0;i<r;i++)
        {
            Console.WriteLine("enter the value of coloum");
            c = int.Parse(Console.ReadLine());
            a[i] = new int[c];
        }
        for(i=0;i<r;i++)
        {
            Console.WriteLine("enter"+a[i].Length+"\tnumber for row\t"+i);
            for(j=0;j<a[i].Length;j++)
            {
                a[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("output :-");
        for(i=0;i<r;i++)
        {
            for(j=0;j<a[i].Length;j++)
            {
            Console.Write(a[i][j]+" ");
            }
            Console.Write("\n");
        }
        
        
    }
}