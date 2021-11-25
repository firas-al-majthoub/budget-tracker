using System;
using Budget_Tracker.Data;
using System.Collections.Generic;
using Budget_Tracker.Repositories;
using Budget_Tracker.Models;

namespace Budget_Tracker.Services
{
    public class BudgetTransactionsService
    {
        private readonly BudgetTransactionsRepository _repository;

        public BudgetTransactionsService(BudgetTransactionsRepository repository)
        {
            _repository = repository;
        }

        public List<BudgetTransaction> GetAll()
        {
            return _repository.GetAll();
        }

        public BudgetTransaction Get(int id)
        {
            return _repository.Get(id);
        }

        public BudgetTransaction Add(AddBudgetTransactionDto dto)
        {
            BudgetTransaction obj = new()
            {
                Description = dto.Description,
                TransactionAmount = dto.TransactionAmount,
                CreateDate = DateTime.Now
            };

            _repository.Add(obj);

            return obj;
        }

        public BudgetTransaction Update(UpdateBudgetTransactionDto dto)
        {
            BudgetTransaction obj = new()
            {
                Id = dto.Id,
                Description = dto.Description,
                TransactionAmount = dto.TransactionAmount,
            };

            return _repository.Update(obj);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
