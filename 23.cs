using System;
class S
{
    public static void Main()
    {
        int a,b,c,d,i;
        Console.WriteLine("enter the value of a and b");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        for(i=a;i<b;i++)
        {
            c = i%10;
            d = i/100;
            //while(j<i)
            //{
            if(c==d)
            {
                Console.WriteLine(i+" ");
            }
            //j++;
            //}
        }

    }
}