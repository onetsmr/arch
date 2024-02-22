using ArchOnion.Domain;
using ArchOnion.Domain.Common;

namespace ArchOnion.DomainServices
{
    public sealed class OrderDomainService
    {
        public Order Create()
        {
            var entity = new Order
            {
                Status = OrderStatusEnum.New
            };

            return entity;
        }
    }
}
