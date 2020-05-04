using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ShoppingApi.Models;

namespace ShoppingApi.Controllers
{
    public class ShoppingListController : ControllerBase
    {
        [HttpGet("shoppinglist")]
        public async Task<ActionResult> GetFullShoppingList()
        {
            var response = new GetShoppingListResponse();

            return Ok(response);
        }
    }
}
