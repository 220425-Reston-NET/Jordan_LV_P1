// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using StoreBL;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace StoreApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class InventoryController : ControllerBase
//     {
//         private IStoreItemBL _storeBL;
//         public InventoryController(IStoreItemBL p_storeBL)
//         {
//             _storeBL = p_storeBL;
//         }

//         [HttpGet("ViewStoreInventory")]
//         public IActionResult ViewStoreInventory([FromQuery] int p_sId)
//         {
//             return Ok(_storeBL.ViewStoreInventory(p_sId));
//         }

//     }
// }