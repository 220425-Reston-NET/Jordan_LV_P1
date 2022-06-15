using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StoreBL;
using StoreModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //=================Dependency Injection=============
        private ICustomerBL _customerBL;
      

        public CustomerController(ICustomerBL storeBL)
        {
            _customerBL = _customerBL;
            
        }

        //=================================================

        //Data annotation to indicate what type of HTTP verb it is
        //This is an action of a controller
        //It needs what HTTP verb it is associated with
        [HttpGet("GetAllCustomerInfo")]
        public async Task<IActionResult> GetAllCustomerInfo()
        {
            try
            {
                List<Customer> listOfCurrentCustomer = await _customerBL.GetAllCustomerInfoAsync();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOfCurrentCustomer);
            }
            catch (SqlException)
            {
                return NotFound("No Store Item Exist");
            }
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer p_customer)
        {
            try
            {
                _customerBL.AddCustomer(p_customer);

                return Created("Item was created!", p_customer);
            }
            catch (SqlException)
            {
                return Conflict();
            }
            catch(System.Exception)
            {
                return Conflict("Store item name already existed");
            }
        }

        [HttpGet("SearchStoreItemByBrand")]
        public IActionResult SearchCustomer([FromQuery] string customerInfo)
        {
            try
            {
                return Ok(_customerBL.SearchCustomerByName(customerInfo));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }


        }
    }
