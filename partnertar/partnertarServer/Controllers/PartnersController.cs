using Newtonsoft.Json;
using partnertarServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace partnertarServer.Controllers
{
    [RoutePrefix("api/partners")]
    public class PartnersController : ApiController
    {
        private readonly IPartnersService _service;

        public PartnersController(IPartnersService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public async Task<string> GetAsync()
        {
            return JsonConvert.SerializeObject( await _service.GetAllAsync());
        }
    }
}
