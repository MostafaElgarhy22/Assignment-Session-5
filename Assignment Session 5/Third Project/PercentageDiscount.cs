using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session_5.Third_Project
{
    internal class PercentageDiscount : Discount
    {
        public decimal perecntage {  get; set; }
        public PercentageDiscount(decimal perecntage)
        {
            Name = "PercentageDiscount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (perecntage / 100); // for be like that %
        }
    }
}
