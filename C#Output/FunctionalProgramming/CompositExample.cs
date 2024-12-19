using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.FunctionalProgramming;

public static class CompositExample
{
    public static void start()
    {
        CalculateFinalCost(FinalComposedFunction(), new Order());

    }
    public static void CalculateFinalCost(Func<Order,int> FreightCost , Order order)
    {
        var freightCost = FreightCost(order);// this is the compose of the three functions
        Console.WriteLine($"Final Cost is Founded and eqaul to {freightCost*100}");
    }
    public static Func<Order,int > FinalComposedFunction()
    {
        Func<Order, string> FindInvoiceDelegate = FindInvoice;
        Func<string, string> FindShippingDelegate = FindShipping;
        Func<string, int> FindFreightCostDelegate = FindFrieghtCost;
        // x=>findFrieght(FindShipping(FindInvoice(Order))) === x is Order and output is int
        return FindInvoiceDelegate.Compose(FindShippingDelegate.Compose(FindFreightCostDelegate));
    }
    public static Func<T1,T3> Compose <T1,T2,T3>(this Func<T1,T2>f1 , Func<T2, T3> f2)
    {

        return (x)=>f2(f1(x));
    }



/// <summary>
/// 
/// Functions we want to compose into one function
/// </summary>
/// <param name="order"></param>
/// <returns></returns>
    public static string FindInvoice (Order order)
    {
        Console.WriteLine("Invoice is Created");
           return "Invoice" ;
    } public static string FindShipping (string invoice)
    {
        Console.WriteLine("Shipping is Found");
           return "Shipping";
    } public static int FindFrieghtCost (string x)
    {
        Console.WriteLine("Frieght cost is Found");
           return 100;
    }
}

