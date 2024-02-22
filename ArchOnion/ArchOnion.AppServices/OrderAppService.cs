using ArchOnion.AppServices.Dto;
using ArchOnion.AppServices.Mappers;
using ArchOnion.Domain;
using ArchOnion.DomainServices;

namespace ArchOnion.AppServices
{
    public sealed class OrderAppService
    {
        private readonly OrderDomainService _orderDomainService;

        public OrderAppService(OrderDomainService orderDomainService)
        {
            _orderDomainService = orderDomainService;
        }

        public Order Create(CreateOrderDto orderDto)
        {
            var entity = _orderDomainService.Create();

            entity.MapFromDto(orderDto);

            return entity;
        }
    }
}
