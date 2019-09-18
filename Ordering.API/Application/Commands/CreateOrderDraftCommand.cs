using MediatR;
using Ordering.API.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API.Application.Commands
{
    public class CreateOrderDraftCommand : IRequest<OrderDraftDTO>
    {

        public string BuyerId { get; private set; }

        public IEnumerable<BasketItem> Items { get; private set; }

        public CreateOrderDraftCommand(string buyerId, IEnumerable<BasketItem> items)
        {
            BuyerId = buyerId;
            Items = items;
        }
    }
}
