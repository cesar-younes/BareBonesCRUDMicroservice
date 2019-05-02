using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BareBonesMicroservice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BareBonesMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BareBonesCRUDController : ControllerBase
    {
        private IBareBonesCRUDRepository _repository;

        public BareBonesCRUDController(IBareBonesCRUDRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.GetItems());
        }
    }
}