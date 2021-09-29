using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public class PostRepo : GenRepo<Post>, IPostRep
    {
        private readonly AppDbContext dbcontext;
        public PostRepo(AppDbContext appContext):base(appContext)
        {
            this.dbcontext = appContext;
        }
    }
}
