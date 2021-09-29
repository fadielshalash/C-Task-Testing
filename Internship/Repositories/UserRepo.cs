using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public class UserRepo:GenRepo<User>,IuserRepo
    {
        private readonly AppDbContext dbcontext;
        public UserRepo(AppDbContext appContext):base(appContext)
        {
            this.dbcontext = appContext;
        }
        public async Task<User> GetUserWithPosts(int id)
        {
            return  dbcontext.Users.Include(x => x.Posts).FirstOrDefault(p => p.id == id);
        }
    }
}
