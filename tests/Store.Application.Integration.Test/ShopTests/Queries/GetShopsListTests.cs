using FluentAssertions;
using NUnit.Framework;
using Store.Application.Shops.Commands;
using Store.Application.Shops.Queries;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Integration.Test.ShopTests.Queries
{
    using static Testing;

    public class GetShopsListTests : TestBase
    {
        [Test]
        public async Task ShouldReturnAllLists()
        {
            await AddAsync(new ShopEntity
            {
                ShopName = "Test Shop",
                Phone = "111-123-1234",
                Email = "test@test.com",
                Street = "Test street",
                City = "Toronto",
                State = "ON",
                PostalCode = "F1E 1D6",
                CreatedDate = DateTime.Now
            });

            var list  =  await SendAsync(new GetAllShopQuery());

            list.Items.Should().HaveCount(1);
        }
    }
}
