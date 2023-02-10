using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ChildrenService : IChildrenService
    {
        private readonly IChildrenRepository _childrenRepository;
        private readonly IMapper _mapper;

        public ChildrenService(IChildrenRepository childrenRepository, IMapper mapper)
        {
            _childrenRepository = childrenRepository;
            _mapper = mapper;
        }

        public async Task<ChildrenDTO> AddAsync(ChildrenDTO childrenDTO)

        {
            var x = GetAllAsync().Result.Find(x => x.IdentityNumber == childrenDTO.IdentityNumber);
            if (x == null)
                return _mapper.Map<ChildrenDTO>(await _childrenRepository.AddAsync(_mapper.Map<Children>(childrenDTO)));
            else
                return childrenDTO;
        }

        public async Task DeleteAsync(int id)
        {
            await _childrenRepository.DeleteAsync(id);
        }

        public async Task<List<ChildrenDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildrenDTO>>(await _childrenRepository.GetAllAsync());
        }

        public async Task<ChildrenDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildrenDTO>(await _childrenRepository.GetByIdAsync(id));
        }

        public async Task<ChildrenDTO> UpdateAsync(ChildrenDTO childDTO)
        {
            return _mapper.Map<ChildrenDTO>(await _childrenRepository.UpdateAsync
                (_mapper.Map<Children>(childDTO)));
        }
    }
}
