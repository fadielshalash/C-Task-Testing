using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public class GenRepo<T> : IgenRepo<T> where T:class,IBM
    {
        private readonly AppDbContext dbcontext;
        public GenRepo(AppDbContext appContext)
        {
            this.dbcontext = appContext;
        }
        public async Task AddObj(T obj)
        {
           await dbcontext.Set<T>().AddAsync(obj);
           await dbcontext.SaveChangesAsync();
        }

        public async Task DeleteByid(int id)
        {
            var filteredUsers =await dbcontext.Set<T>().FirstOrDefaultAsync(obj => obj.id.Equals(id));
            if (filteredUsers != null)
                dbcontext.Set<T>().Remove(filteredUsers);
            dbcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await  dbcontext.Set<T>().ToListAsync();
            
        }

        public async Task<T> GetById(int id)
        {
            return await dbcontext.Set<T>().FirstOrDefaultAsync(obj =>obj.id.Equals(id));
        }

        public async Task<IEnumerable<T>> GetPage(int size, int index)
        {
            return dbcontext.Set<T>().Take(size).ToList().Skip(size * (index - 1));
        }

    }
}
