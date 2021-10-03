using Store.Domain.Entities.Base;

namespace Store.Domain.Entities
{
    public class ShopEntity : BaseEntity
    {
        public string ShopName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
