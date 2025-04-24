using Ecommerce.Customers.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(string name, string pass)
        {

            var result = await _customerService.GetAllAsync(name, pass);
            if (result is null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        //[HttpPost ("AddCustomer")]
        //public async Task<IActionResult> AddCustomer(Customer customer)
        //{
        //     _customerService.PostAsync(customer);
        //    return Ok();
        //}



    }
}


//using Ecommerce.Products.Dtos;
//using Ecommerce.Products.Services;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Ecommerce.Products.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CustomerController : ControllerBase
//    {
//        private readonly ICustomerService _customerService;
//        public CustomerController(ICustomerService customerservice)
//        {
//            _customerService = customerservice;
//        }
//        [HttpGet("Get All Customer")]
//        public IActionResult Get()
//        {
//            var customer = _customerService.GetCustomer();
//            if (customer == null)
//            {
//                return NotFound();
//            }
//            else
//            {
//                return Ok(customer);
//            }
//            //object key result
//        }
//        [HttpPost("Add Customer")]
//        public IActionResult Postcustomer(Customer_Dto customer)
//        {
//            _customerService.PostCustomer(customer);
//            return Ok();

//        }
//    }
//}
