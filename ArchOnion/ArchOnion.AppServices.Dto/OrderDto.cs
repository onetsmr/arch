using ArchOnion.Domain.Common;

namespace ArchOnion.AppServices.Dto
{
    public sealed record OrderDto
    {
        public OrderStatusEnum Status { get; set; }

        public string Number { get; set; }

        public string Address { get; set; }

        public decimal Total { get; set; }

        public OrderLineDto[] Lines { get; set; }
    }
}
