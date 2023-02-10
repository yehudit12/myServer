using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Controllers.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildrenService _childrenService;

        public ChildrenController(IChildrenService childrenService)
        {
            _childrenService = childrenService;
        }

        [HttpGet]
        public async Task<IEnumerable<ChildrenDTO>> Get()
        {
            return await _childrenService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ChildrenDTO> Get(int id)
        {
            return await _childrenService.GetByIdAsync(id);
        }

        [HttpPost]//add
        public async Task<ChildrenDTO> Post([FromBody] ChildrenModel model)
        {
            ChildrenDTO childrenDTO = new ChildrenDTO()
            {
                IdentityNumber = model.IdentityNumber,
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                IdParent = model.IdParent
            };
            return await _childrenService.AddAsync(childrenDTO);
        }

        [HttpPut("{id}")]//update
        public async Task<ChildrenDTO> Put(int id, [FromBody] ChildrenModel model)
        {
            ChildrenDTO childDTO = new ChildrenDTO()
            {
                ChildId = id,
                IdentityNumber = model.IdentityNumber,
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                IdParent = model.IdParent
            };
            return await _childrenService.UpdateAsync(childDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childrenService.DeleteAsync(id);
        }

    }
}

