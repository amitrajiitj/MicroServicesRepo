using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void CreateAccount([FromBody] string customerData)
        {
            //do nothing
        }

        [HttpPost]
        public void UpdateAccount([FromBody] string customerData)
        {
            //do nothing
        }

        [HttpGet]
        public IList<string> GetAccounts(string userId)
        {
            return new List<string>();
            //do nothing
        }


        [HttpPost]
        public void RemoveAccount([FromBody] string accountId)
        {
            //do nothing
        }

        [HttpPost]
        public void DepositMoneyToAccount([FromBody] double amount, string accountNumber)
        {
            //do nothing
        }

        [HttpPost]
        public void WithdrawMoneyFromAccount([FromBody] double amount, [FromBody] string accountNumber)
        {
            //do nothing
        }

        [HttpPost]
        public void TransferMoneyFromAccountToAnotherAccount([FromBody] double amount, [FromBody] string accountNumber, [FromBody] string receiverAccountNumber)
        {
            //do nothing
        }

    }
}