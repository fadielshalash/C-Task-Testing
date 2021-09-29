using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public interface IuserRepo : IgenRepo<User>
    {
        Task<User> GetUserWithPosts(int id);
    }
}