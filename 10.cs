// static data member abd static data type
using System;
class Bank
{
    private int acno;
    private string cname;
    private int cbal;
    private static int bbal;

    public void GetDetails()
    {
        Console.WriteLine("enter account no.,customer name, balance");
        acno = int.Parse(Console.ReadLine());
        cname = Console.ReadLine();
        cbal = int.Parse(Console.ReadLine());
        bbal = bbal + cbal;
    }
    public void ShowDetails()
    {
        Console.WriteLine("acccount no ="+acno);
        Console.WriteLine("customer name ="+cname);
        Console.WriteLine("customer blance="+cbal);
    }
    public static void ShowTotal()
    {
        Console.WriteLine("Total balance ="+bbal);
    }
}

class Demo
{
    public static void Main()
    {
        Bank cust1 = new Bank();
        Bank cust2 = new Bank();
        cust1.GetDetails();
        cust2.GetDetails();
        cust1.ShowDetails();
        cust2.ShowDetails();
        Bank.ShowTotal();
    }
}