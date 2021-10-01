using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    [Route("api/store")]
    [ApiController]
    public class StoreController : ApiBaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<string>> Get()
        {
            var list = new List<string>() { "Name", "LastName"};
            return list;//await _mediator.Send(new GetAllCustomerQuery());
        }
    }
}
