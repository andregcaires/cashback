using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cashback.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private IAlbumService _service;
        public AlbumController(IAlbumService service)
        {
            _service = service;
        }

        // GET: api/Album
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_service.SelectAll());
        }

        // GET: api/Album/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Album
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Album/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
