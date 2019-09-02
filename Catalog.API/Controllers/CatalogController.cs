using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.IntegrationEvents.Events;
using EventBus.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IEventBus _eventBus;

        public CatalogController(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        //[Route("item")]
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [Route("items")]
        [HttpPost]
        public async Task<IActionResult> UpdateProduct([FromBody]CatalogItem item)
        {
            var @event = new ProductPriceChangedIntegrationEvent(item.ProductId, item.NewPrice, item.OldPrice);
             _eventBus.Publish(@event);
            return Ok(@event);
        }
    }
}