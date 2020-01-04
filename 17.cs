// primt pime num with a range
using System;
class B
{
    public static void Main()
    {
        int m,n,i,flag;
        Console.WriteLine("enter the value of m and n");
        m = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("prime nu bet the interval are");
        while(m<n)
        {
            flag = 0;
            for(i=2;i<=m/2;i++)
            {
                if(m%i==0)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine(m+"\n");
            }
            m++;
        }
    }
}