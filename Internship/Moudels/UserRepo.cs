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

    }
}
