namespace ArchOnion.AppServices.Dto
{
    public sealed record OrderLineDto
    {
        public uint Id { get; set; }

        public string Number { get; set; }

        public string SKU { get; set; }

        public uint Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Total { get; set; }
    }
}
