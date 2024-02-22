namespace ArchOnion.AppServices.Dto
{
    public sealed record CreateOrderLineDto
    {
        public string Number { get; set; }

        public string SKU { get; set; }

        public uint Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
