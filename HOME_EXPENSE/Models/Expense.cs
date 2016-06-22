using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOME_EXPENSE.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public List<string> ExpenseType { get; set; }
        public DateTime ExpenseDate { get; set; }
        public double Amount { get; set; }
        public string Details { get; set; }

    }
}