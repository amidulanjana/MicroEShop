using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ordering.API.Application.Queries;
using Ordering.API.Infrastructure.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ordering.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IOrderQueries _orderQueries;
        private readonly IIdentityService _identityService;
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(
           IMediator mediator,
           IOrderQueries orderQueries,
           IIdentityService identityService,
           ILogger<ValuesController> logger)
        {
            _mediator = mediator; //?? throw new ArgumentNullException(nameof(mediator));
            _orderQueries = orderQueries; //?? throw new ArgumentNullException(nameof(orderQueries));
            _identityService = identityService; //?? throw new ArgumentNullException(nameof(identityService));
            _logger = logger; //?? throw new ArgumentNullException(nameof(logger));
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
