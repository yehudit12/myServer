using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
  public  class ChildrenRepository:IChildrenRepository
    {
        private readonly IProjectContext _projectContext;
        public ChildrenRepository(IProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public async Task<Children> AddAsync(Children child)
        {
            var add = _projectContext.ChildrenTable.Add(child);
           await _projectContext.SaveChangesAsync();
           return add.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _projectContext.ChildrenTable.Remove(await GetByIdAsync(id));
           await _projectContext.SaveChangesAsync();
        }

        public async Task<List<Children>> GetAllAsync()
        {
            return await _projectContext.ChildrenTable.Include(p=>p.Parent).ToListAsync();
        }

        public async Task<Children> GetByIdAsync(int id)
        {
            return await _projectContext.ChildrenTable.Include(p=>p.Parent).FirstOrDefaultAsync(p=>p.ChildId==id);
        }

        public async Task<Children> UpdateAsync(Children child)
        {
            var update = _projectContext.ChildrenTable.Update(child);
           await _projectContext.SaveChangesAsync();
            return update.Entity;
        }
    }
}

