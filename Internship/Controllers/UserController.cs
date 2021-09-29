using AutoMapper;
using Internship.Moudels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        AppDbContext dbContext;
        IuserRepo MyUser =null;
       private readonly IMapper _mapper;

        public UserController(IMapper mapper, IuserRepo MyUser, AppDbContext dbContext)
        {
            this.MyUser = MyUser;
            this._mapper = mapper;
            this.dbContext = dbContext;
        }
        
        //[HttpGet]
        //public IActionResult GetUser()
        //{

        //    List<UserVeiwModel>UVM = _mapper.Map<List<User>, List<UserVeiwModel>>(MyUser.GetAll());
        //    return Ok(UVM);
        //}

        [HttpGet("{id}")]
        public  async Task<UserViewModel> GetUser(int id)
        {
            
            UserViewModel UVM =  _mapper.Map<UserViewModel>(await MyUser.GetById(id));
            return UVM;
        }
        

        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> GetAllUsers()
        {
            var u = _mapper.Map<IEnumerable<UserViewModel>>(await MyUser.GetAll());
            return u;
        }

        [HttpDelete]
        public async Task DeleteByid(int id)
        {
           await MyUser.DeleteByid(id);
        }

        [HttpPost]
        public async Task AddObj(User obj)
        {
           await MyUser.AddObj(obj);
        }

        [HttpGet("{size}/{index}")]
        public Task<IEnumerable<User>> GetPages(int size, int index)
        {
            return MyUser.GetPage(size, index);
        }

        [HttpGet("withposts/{id}")]
        public Task<User> GetUserWithPosts(int id)
        {

            return MyUser.GetUserWithPosts(id);
        }















        //[HttpPost]
        //public void AddUser([FromBody] User user)
        //{
        //    MyUser.AddObj(user);
        //}







        //public UserController(IuserRepo myUser)
        //{
        //    MyUser = myUser;
        //}



        //[HttpGet("{id}")]
        //public User GetUser(int id)
        //{
        //    return MyUser.GetByid(id);
        //}

        //[HttpDelete("{id}")]
        //public  void DeleteUser(int id)
        //{
        //    MyUser.DeleteByid(id);

        //}


        //[HttpPost]
        //public void AddUser([FromBody] User user)
        //{
        //    MyUser.AddObj(user);
        //}

        /*

        [HttpGet]
        public List<User> Get()
        {
            return users.GetAll();
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return users.GetUser(id);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            users.DeleteUser(id);
        }

        [HttpPost]
        public void AddUser([FromBody]User user)
        {
            users.AddUser(user);
        }
        */
    }
}
