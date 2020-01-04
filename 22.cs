// amstrong in a range of given num
using System;
class A
{
    public static void Main()
    {
        int low,high,flag=0,rem,sum=0,temp;
        Console.WriteLine("enter the value of low and high");
        low = int.Parse(Console.ReadLine());
        high = int.Parse(Console.ReadLine());
        while(low<high)
        {
            temp = low;
            rem = low%10;
            sum = sum + rem*rem*rem;
            low = low/10;
            if(temp == sum)
            {
                flag = 1;
            }
            low++;
        }
        if(flag == 1)
        {
            Console.WriteLine(low);
        }
    }
}