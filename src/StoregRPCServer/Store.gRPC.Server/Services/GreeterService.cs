using Grpc.Core;
using MediatR;
using Microsoft.Extensions.Logging;
using Store.Application.Shops.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.gRPC.Server
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly IMediator _mediator;
        public GreeterService(ILogger<GreeterService> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public override async Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {

            var res = await _mediator.Send(new GetAllShopQuery());
            return new HelloReply
            {
                Message = "Hello " + res.Items[0].ShopName
            };
        }
    }
}
