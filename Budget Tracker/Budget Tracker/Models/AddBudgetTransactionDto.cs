using System;

namespace Budget_Tracker.Models
{
    public class AddBudgetTransactionDto
    {
        public string Description { get; set; }
        public int TransactionAmount { get; set; }
    }
}
