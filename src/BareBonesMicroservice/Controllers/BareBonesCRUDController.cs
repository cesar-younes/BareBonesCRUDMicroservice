using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BareBonesCRUDMicroservice.Interfaces;
using BareBonesCRUDMicroservice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BareBonesMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BareBonesCRUDController : ControllerBase
    {
        private IAsyncRepository<BareBonesCRUDItem> _repository;

        public BareBonesCRUDController(IAsyncRepository<BareBonesCRUDItem> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.ListAllAsync());
        }
    }
}