namespace ArchOnion.AppServices.Dto
{
    public sealed record CreateOrderDto
    {
        public string Number { get; set; }

        public string Address { get; set; }

        public CreateOrderLineDto[] Lines { get; set; }
    }
}
