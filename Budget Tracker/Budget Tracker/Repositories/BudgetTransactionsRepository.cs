using System.Linq;
using Budget_Tracker.Data;
using System.Collections.Generic;

namespace Budget_Tracker.Repositories
{
    public class BudgetTransactionsRepository
    {
        private readonly BudgetTrackerDbContext _dbContext;

        public BudgetTransactionsRepository(BudgetTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BudgetTransaction> GetAll()
        {
            return _dbContext.BudgetTransactions.ToList();
        }

        public BudgetTransaction Get(int id)
        {
            return _dbContext.BudgetTransactions.SingleOrDefault(bt => bt.Id == id);
        }

        public void Add(BudgetTransaction obj)
        {
            _dbContext.BudgetTransactions.Add(obj);
            _dbContext.SaveChanges();
        }

        public BudgetTransaction Update(BudgetTransaction obj)
        {
            BudgetTransaction updated = _dbContext.BudgetTransactions.SingleOrDefault(bt => bt.Id == obj.Id);

            updated.Description = obj.Description;
            updated.TransactionAmount = obj.TransactionAmount;

            _dbContext.SaveChanges();

            return updated;
        }

        public void Delete(int id)
        {
            _dbContext.BudgetTransactions.Remove(_dbContext.BudgetTransactions.SingleOrDefault(bt => bt.Id == id));
            _dbContext.SaveChanges();
        }
    }
}
