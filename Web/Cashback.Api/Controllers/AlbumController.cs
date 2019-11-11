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
    [Route("[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private IAlbumService _service;
        public AlbumController(IAlbumService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("~/[controller]")]
        public JsonResult Get([FromQuery]string musicStyle = "",
                            [FromQuery] int page = 0,
                            [FromQuery] int pageSize = 10)
        {
            try
            {
                return new JsonResult(_service.GetPaged(page, pageSize, musicStyle));
            } catch (Exception e)
            {
                return new JsonResult(e.Message);
            }
        }

        [HttpGet]
        [Route("~/[controller]/{id:int}")]
        public JsonResult GetById([FromRoute]int id)
        {
            try
            {
                return new JsonResult(_service.FindById(id));
            }
            catch (Exception e)
            {
                return new JsonResult(e.Message);
            }
        }

    }
}
