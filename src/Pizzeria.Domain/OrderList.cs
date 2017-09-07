using System;
using System.Collections.ObjectModel;

namespace Pizzeria.Domain
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

        public static OrderList Instance => _instance.Value;
    }
}
