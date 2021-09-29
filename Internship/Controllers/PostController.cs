using AutoMapper;
using Internship.Moudels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        AppDbContext dbContext;
        IPostRep MyPost = null;
        private readonly IMapper _mapper;
        public PostController(IMapper mapper, IPostRep MyPost, AppDbContext dbContext)
        {
            this.MyPost = MyPost;
            this._mapper = mapper;
            this.dbContext = dbContext;
        }


        [HttpGet("{id}")]
        public async Task<Post> GetPost(int id)
        {
            return await MyPost.GetByid(id);
           
        }


        [HttpGet]
        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await MyPost.GetAll();
        }

        [HttpDelete]
        public async Task DeleteByid(int id)
        {
           await MyPost.DeleteByid(id);
        }

        [HttpPost]
        public async Task AddObj(Post obj)
        {
            await MyPost.AddObj(obj);
        }

        //[HttpGet]
        //public IActionResult GetPost()
        //{

        //    List<PostVeiwModel> UVM = _mapper.Map<List<Post>, List<PostVeiwModel>>(MyPost.GetAll());
        //    return Ok(UVM);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetPost(int id)
        //{

        //    PostVeiwModel UVM = _mapper.Map<PostVeiwModel>(MyPost.GetByid(id));
        //    return Ok(UVM);
        //}

        //[HttpGet("{size}/{index}")]
        //public List<Post> getpages(int size, int index)
        //{
        //    return dbContext.Posts.Take(size).Skip(size * (index - 1)).ToList();
        //}




        //IPostRep MyPost = null;

        //public PostController(IPostRep MyPost)
        //{
        //   this. MyPost = MyPost;
        //}

        //[HttpGet]
        //public IEnumerable<Post> GetAllPosts()
        //{
        //    return MyPost.GetAll();

        //}

        //[HttpGet("{id}")]
        //public Post GetPost(int id)
        //{
        //    return MyPost.GetByid(id);
        //}

        //[HttpDelete("{id}")]
        //public  void DeletePost(int id)
        //{
        //    MyPost.DeleteByid(id);

        //}

        //[HttpPost]
        //public void AddPost([FromBody] Post post)
        //{
        //    MyPost.AddObj(post);
        //}
    }
    }

