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
        public  async Task<User> GetUser(int id)
        {
            return await MyUser.GetByid(id);
            //UserVeiwModel UVM = _mapper.Map<UserVeiwModel>(MyUser.GetByid(id));
            //return Ok(UVM);
        }
        

        [HttpGet]
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await MyUser.GetAll();
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




















        //[HttpPost]
        //public void AddUser([FromBody] User user)
        //{
        //    MyUser.AddObj(user);
        //}

        //[HttpGet("{size}/{index}")]
        //public List<User> getpages(int size,int index)
        //{
        //    return dbContext.Users.Take(size).Skip(size * (index - 1)).ToList();
        //}
        //[HttpGet("getuserwithpostby/{id}")]
        //public User getUser(int id)
        //{
        //    return dbContext.Users.Include(x => x.Posts).FirstOrDefault(x => x.id == id);
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
