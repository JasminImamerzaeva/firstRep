using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УправлениеПутешествиями
{
    public class Expense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public Expense(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }
    }

}
