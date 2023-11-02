using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadReportOZON
{
    internal class Products
    {
        public string Name { get; private set; }
        public string Article { get; private set; }
        public decimal Price {  get; private set; }
        public int Quantity { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Commission { get; private set; }
        public decimal Logistics { get; private set; }
        public decimal LogisticsReturn { get; private set; }

        public Products(string name, string article, decimal price, int quantity, decimal amount, decimal commission, decimal logistics, decimal logisticsReturn)
        {
            Name = name;
            Article = article;
            Price = price;
            Quantity = quantity;
            Amount = amount;
            Commission = commission;
            Logistics = logistics;
            LogisticsReturn = logisticsReturn;
        }
    }
}
