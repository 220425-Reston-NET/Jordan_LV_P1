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
    public class StoreController : ControllerBase
    {
        //=================Dependency Injection=============
        private IStoreItemBL _storeBL;
        private IStoreAbilityJoinBL _storeJoin;

        public StoreController(IStoreItemBL storeBL, IStoreAbilityJoinBL storeJoin)
        {
            _storeBL = storeBL;
            _storeJoin = storeJoin;
        }

        //=================================================

        //Data annotation to indicate what type of HTTP verb it is
        //This is an action of a controller
        //It needs what HTTP verb it is associated with
        [HttpGet("GetAllStoreItem")]
        public async Task<IActionResult> GetAllStoreItem()
        {
            try
            {
                List<StoreItem> listOfCurrentStoreItem = await _storeBL.GetAllStoreItemAsync();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOfCurrentStoreItem);
            }
            catch (SqlException)
            {
                return NotFound("No Store Item Exist");
            }
        }

        [HttpPost("AddStoreItem")]
        public IActionResult AddStoreItem([FromBody] StoreItem p_store)
        {
            try
            {
                _storeBL.AddStoreItem(p_store);

                return Created("Item was created!", p_store);
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
        public IActionResult SearchStoreItem([FromQuery] string ItemBrand)
        {
            try
            {
                return Ok(_storeBL.SearchStoreItemByName(ItemBrand));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpPut("ReplenishStoreItem")]
        public IActionResult ReplenishStoreItem([FromQuery] int p_StoreItemId, [FromQuery] string p_Material, [FromQuery] string p_Color, [FromQuery] int p_Quantity, [FromQuery] int p_Size)
        {
            StoreItem found = _storeBL.SearchStoreItemById(p_StoreItemId);

            if (found == null)
            {
                return NotFound("Store item was not found!");
            }
            //Another logic to check if the store item has the ability
            else
            {
                try
                {
                    _storeJoin.ReplenishAbilityStoreItem(p_Size, p_Quantity, p_Material, p_Color );

                    return Ok();
                }
                catch (SqlException)
                {
                    return Conflict();
                    
                }

            }
        }
    }
}