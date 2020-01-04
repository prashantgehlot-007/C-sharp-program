// jagged array decleearation

//datatype [][]arrayname = new datatype[rowsize][];
using System;
class A
{
    public static void Main()
    {
        int [][]a = new int[3][];
        int i,j;
        a[0] = new int[2];
        a[1] = new int[3];
        a[2] = new int[4];
        for(i=0;i<3;i++)
        {
            for(j=0;j<a[i].Length;j++)
            {
                Console.WriteLine("enter number a"+i+j);
                a[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("output :-");
        for(i=0;i<3;i++)
        {
            for(j=0;j<a[i].Length;j++)
            {
                Console.Write(a[i][j]+" ");
            }
            Console.Write("\n");
        }
    }
}