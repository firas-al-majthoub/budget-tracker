namespace Budget_Tracker.Models
{
    public class UpdateBudgetTransactionDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TransactionAmount { get; set; }
    }
}
