// check amstrong or not

using System;
class Z
{
    public static void Main()
    {
        int n,temp,rem,sum;
        Console.WriteLine("entet the vakue of num");
        n = int.Parse(Console.ReadLine());
        temp = n;
        sum = 0;
        while(n>0)
        {
            rem = n%10;
            sum = sum + rem*rem*rem;
            n = n/10;     
        }
        if(temp == sum)
        {
            Console.WriteLine("amstrong");
        }
        else
        {
            Console.WriteLine("not amstrong");
        }

    }
}