using ArchOnion.AppServices;
using ArchOnion.AppServices.Dto;
using ArchOnion.AppServices.Mappers;
using ArchOnion.Database;
using Microsoft.AspNetCore.Mvc;

namespace ArchOnion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository _orderRepository;
        private readonly OrderAppService _orderAppService;

        public OrderController(OrderRepository orderRepository, OrderAppService orderAppService)
        {
            _orderRepository = orderRepository;
            _orderAppService = orderAppService;
        }

        [HttpGet, Route("")]
        public IEnumerable<OrderDto> GetList(object parameters)
        {
            return _orderRepository.Select(parameters).Select(e => e.MapToDto());
        }

        [HttpPost, Route("")]
        public OrderDto Create(CreateOrderDto orderDto)
        {
            var entity = _orderAppService.Create(orderDto);

            _orderRepository.Insert(entity);

            return entity.MapToDto();
        }
    }
}
