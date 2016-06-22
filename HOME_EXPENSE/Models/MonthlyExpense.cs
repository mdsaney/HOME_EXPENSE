using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOME_EXPENSE.Models
{
    public class MonthlyExpense
    {
        public int MonthlyExpenseId { get; set; }
        public double TotalExpense { get; set; }
        public double TotalIndividualExpense { get; set; }
        public double NeedToPay { get; set; }
        public double WillGet { get; set; }



    }
}