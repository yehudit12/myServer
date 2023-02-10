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
    public class UserRepository : IUserRepository
    {
        private readonly IProjectContext _projectContext;
        public UserRepository(IProjectContext projectContext) 
        {
            _projectContext = projectContext;
        }
        public async Task<User> AddAsync(User user)
        {
            var add= _projectContext.UserTable.Add(user);
           await _projectContext.SaveChangesAsync();
            return add.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _projectContext.UserTable.Remove(await GetByIdAsync(id));
          await _projectContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _projectContext.UserTable.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _projectContext.UserTable.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var update = _projectContext.UserTable.Update(user);
            await _projectContext.SaveChangesAsync();
            return update.Entity;
        }
    }
}
