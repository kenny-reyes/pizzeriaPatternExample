using System;
using System.Collections.ObjectModel;

namespace Pizzeria.Domain.Base
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class OrderList : ObservableCollection<Order>
    {
        private static readonly Lazy<OrderList> _instance = new Lazy<OrderList>(() => new OrderList());

        private OrderList()
        {
        }

        public static OrderList Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
