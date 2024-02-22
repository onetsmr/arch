using ArchOnion.Domain.Common;

namespace ArchOnion.Domain
{
    public sealed class OrderLine : BaseEntity<uint>
    {
        public string Number { get; set; }

        public string SKU { get; set; }

        public uint Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Total => Quantity * Price;
    }
}
