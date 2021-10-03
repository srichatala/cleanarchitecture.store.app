using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Shops.Commands;
using Store.Application.Shops.Queries;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    [Route("api/store")]
    [ApiController]
    public class ShopController : ApiBaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Post(CreateShopCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAllShopQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetShopByIdQuery { Id = id }));
        }

        [HttpPut("[action]")]
        public async Task<ActionResult> UpdateItemDetails(int id, EditShopCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteShopCommand { Id = id }));
        }
    }
}
