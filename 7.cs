// two dim array
using System;
class A
{
    public static void Main()
    {
        int [,]a = new int[2,4];
        int i,j;
        for(i=0;i<2;i++)
        {
            for(j=0;j<4;j++)
            {
                Console.WriteLine("enter element of matrix a"+i+j);
                a[i,j] = int.Parse(Console.ReadLine());
            }
        }
        //print matrix
        for(i=0;i<2;i++)
        {
            for(j=0;j<4;j++)
            {
                Console.Write(a[i,j]+" ");
            }
            Console.Write("\n");
        }
    }
}