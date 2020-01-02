using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BareBonesCRUDMicroservice.Interfaces;
using BareBonesCRUDMicroservice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BareBonesCRUDMicroservice.Controllers
{
    [Route("api/v1/[controller]")]
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

        [HttpPost]
        public IActionResult Post()
        {
            BareBonesCRUDItem bareBonesCRUDItem = new BareBonesCRUDItem()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString("n").Substring(0, 8),
                Status = ItemStatus.FromValue(new Random().Next(4)),
                Items = new List<SubBareBonesCRUDItem>()
            };
            return Ok(_repository.AddAsync(bareBonesCRUDItem));
        }
    }
}