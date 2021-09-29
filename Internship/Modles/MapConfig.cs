using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public class MapConfig:Profile
    {
        public MapConfig()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
        }
    }
        
}
