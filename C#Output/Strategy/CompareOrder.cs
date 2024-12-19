using C_Output.FunctionalProgramming;
 

namespace C_Output.Strategy
{
    internal class CompareOrder : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            var res  = (int)(x.price - y.price);
            return res;
        }
    }
}
