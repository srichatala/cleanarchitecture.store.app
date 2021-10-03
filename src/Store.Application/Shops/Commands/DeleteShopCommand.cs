using MediatR;
using System;

namespace Store.Application.Shops.Commands
{
    public class DeleteShopCommand : IRequest
    {
        public Int64 Id { get; set; }
    }
}
