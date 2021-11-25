using Budget_Tracker.Data;
using Budget_Tracker.Models;
using Budget_Tracker.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Budget_Tracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BudgetTransactionsController : ControllerBase
    {
        private readonly BudgetTransactionsService _service;

        public BudgetTransactionsController(BudgetTransactionsService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<BudgetTransaction> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var res = _service.Get(id);

            if (res != null)
                return Ok(res);

            return NotFound();
        }

        [HttpPost]
        public BudgetTransaction Add(AddBudgetTransactionDto dto)
        {
            return _service.Add(dto);
        }

        [HttpPut]
        public BudgetTransaction Update(UpdateBudgetTransactionDto dto)
        {
            return _service.Update(dto);
        }

        [HttpDelete]
        [Route("{id}")]
        public BudgetTransaction Delete(int id)
        {
            BudgetTransaction obj = _service.Get(id);
            _service.Delete(id);

            return obj;
        }
    }
}
