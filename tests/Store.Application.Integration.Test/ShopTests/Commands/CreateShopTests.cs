using FluentAssertions;
using NUnit.Framework;
using Store.Application.Shops.Commands;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Integration.Test.ShopTests.Commands
{
    using static Testing;

    public class CreateShopTests : TestBase
    {
        [Test]
        public async Task ShouldCreateTodoItem()
        {
            var command = new CreateShopCommand
            {
                ShopName = "Test Shop",
                Phone = "111-123-1234",
                Email = "test@test.com",
                Street = "Test street",
                City = "Toronto",
                State = "ON",
                PostalCode = "F1E 1D6"
            };

            var item = await SendAsync(command);

            item.Should().NotBeNull();
        }
    }
}
