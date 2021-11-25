using System;

namespace Budget_Tracker.Data
{
    public class BudgetTransaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TransactionAmount { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
