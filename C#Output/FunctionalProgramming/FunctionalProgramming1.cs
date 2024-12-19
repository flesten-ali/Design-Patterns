using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.FunctionalProgramming
{
    public class FunctionalProgramming1
    {

      List<Order> orders  = new List<Order>();

        public void CalculateDiscount()
        {
            var OrdersWithDiscount = orders.Select(order => GetDiscount(order, GetRules()));

        }

        private Order GetDiscount(Order order, List<(Func<Order, bool> Qulification, Func<Order, decimal> Calculation)> rules)
        {
            var orderDiscount = rules.Where(rule=>rule.Qulification(order)).Select(x=>x.Calculation(order)).OrderBy(y=>y).Take(3).Average();
            order.price *= orderDiscount;
            return order;
        }

        private List<(Func<Order,bool> , Func<Order,decimal>)> GetRules()
        {
            var rules = new List<(Func<Order, bool>, Func<Order, decimal>)>()
            {
                (QulificationOne , One),
                (QulificationTwo , Two),
            };
            return rules;
        }

      
        private bool QulificationOne(Order order)
        {
            return true;

        }
        private bool QulificationTwo(Order order)
        {
            return true;
        }

        private decimal One(Order order)
        {
            return order.price * 100;
        }
        private decimal Two(Order order)
        {
            return order.price * 200;
        }

    }
}
