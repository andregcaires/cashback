using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Cashback.Service.DTO;
using Cashback.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cashback.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private ISaleService _service;
        public SaleController(ISaleService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("~/[controller]")]
        public JsonResult Get([FromQuery]string initialDate, [FromQuery]string endDate,
                            [FromQuery] int page = 0,
                            [FromQuery] int pageSize = 10)
        {
            try
            {
                if (string.IsNullOrEmpty(endDate) && string.IsNullOrEmpty(initialDate))
                {
                    return new JsonResult(_service.SelectAll());
                }
                
                return new JsonResult(_service.GetPaged(page, pageSize, ValidateDate(initialDate, "yyyy-MM-dd"), ValidateDate(endDate, "yyyy-MM-dd")));
            }
            catch (Exception e)
            {
                return new JsonResult(e.Message);
            }
        }

        private DateTime ValidateDate(string value, string dateFormats)
        {
            DateTime tempDate;
            bool validDate = DateTime.TryParseExact(value, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out tempDate);
            if (validDate)
                return tempDate;
            else
                throw new Exception("Invalid date");
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

        [HttpPost]
        public JsonResult Post(List<AlbumDTO> dtos)
        {
            try
            {
                return new JsonResult(_service.RegisterSale(dtos));
            } 
            catch(Exception e)
            {
                return new JsonResult(e);
            }
        }
    }
}