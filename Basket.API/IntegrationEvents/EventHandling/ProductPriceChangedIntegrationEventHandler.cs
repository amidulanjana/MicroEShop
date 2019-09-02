using Basket.API.IntegrationEvents.Events;
using EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.IntegrationEvents.EventHandling
{
    public class ProductPriceChangedIntegrationEventHandler : IIntegrationEventHandler<ProductPriceChangedIntegrationEvent>
    {
        private readonly ILogger<ProductPriceChangedIntegrationEventHandler> _logger;

        public ProductPriceChangedIntegrationEventHandler(
            ILogger<ProductPriceChangedIntegrationEventHandler> logger
           )
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            //_repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Task Handle(ProductPriceChangedIntegrationEvent @event)
        {
            _logger.LogInformation("----- Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})", @event.Id, "Program.AppName", @event);

            return Task.CompletedTask;
        }
    }
}
