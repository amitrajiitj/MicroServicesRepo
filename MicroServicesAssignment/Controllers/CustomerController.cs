using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace MicroServicesAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        ConfigSettings configSettings { get; set; }

        public CustomerController(IOptions<ConfigSettings> settings)
        {
            configSettings = settings.Value;
        }
        public IActionResult Index()
        {
            return Content(configSettings.Message);
        }

        [HttpPost]
        public void RegisterCustomer([FromBody] string customerData)
        {
            //do nothing
        }

        [HttpPost]
        public void UpdateCustomerInfo([FromBody] string customerData)
        {
            //do nothing
        }


        [HttpPost]
        public void OrderChequeBook()
        {
            //do nothing
        }


        [HttpPost]
        public void CancelChequeBook()
        {
            //do nothing
        }
    }
}