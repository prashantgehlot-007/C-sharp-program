// primt pime num with a range
using System;
class B
{
    public static void Main()
    {
        int i,j,flag;
        //Console.WriteLine("enter the value of m and n");
        //m = int.Parse(Console.ReadLine());
        //n = int.Parse(Console.ReadLine());
        Console.WriteLine("prime nu bet the interval are");
        for(i=101;i<150;++i)
        {
            flag = 0;
            for(j=2;j<=i/2;j++)
            {
                if(i%j==0)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine(i+"\n");
            }
        }
    }
}