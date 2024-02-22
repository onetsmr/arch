using ArchOnion.Domain.Common;

namespace ArchOnion.Domain
{
    public sealed class Order : BaseEntity<uint>
    {
        public OrderStatusEnum Status { get; set; }

        public string Number { get; set; }

        public string Address { get; set; }

        public decimal Total { get; set; }

        public IEnumerable<OrderLine> Lines => _lines;
        private readonly List<OrderLine> _lines = [];

        public void AddLine(OrderLine line)
        {
            _lines.Add(line);

            RecalculateTotal();
        }

        private void RecalculateTotal()
        {
            Total = _lines.Sum(e => e.Total);
        }
    }
}
