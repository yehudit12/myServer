using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IChildrenRepository
    {
        Task<List<Children>> GetAllAsync();
        Task<Children> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<Children> UpdateAsync(Children child);
        Task<Children> AddAsync(Children child);
    }
}
