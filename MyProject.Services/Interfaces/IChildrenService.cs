using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
   public interface IChildrenService
    {
        Task<List<ChildrenDTO>> GetAllAsync();
        Task<ChildrenDTO> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<ChildrenDTO> UpdateAsync(ChildrenDTO childrenDTO);
        Task<ChildrenDTO> AddAsync(ChildrenDTO childrenDTO);
    }
}
