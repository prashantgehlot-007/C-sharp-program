// switch case program
using System;
class A
{
    public static void Main()
    {
        int a,b,c,ch;
        ch =1;
        while(ch!=5)
        {
            Console.WriteLine("enter value os a,b");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter choice\n 1.a\n2.sub\n3.multi\n4.div\n5.exit");
            ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                c= a+b;
                Console.WriteLine("sum="+c);
                break;

                case 2:
                c= a-b;
                Console.WriteLine("sub="+c);
                break;

                case 3:
                c= a*b;
                Console.WriteLine("multiply="+c);
                break;

                case 4:
                c= a/b;
                Console.WriteLine("div="+c);
                break;

                case 5:
                Console.WriteLine("page is not found");
                break;

                default:
                Console.WriteLine("invalid value");
                break;



            }
        }
    }
}