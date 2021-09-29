using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public class User:IBM
    {
        

        public int id { set; get; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }

        public ICollection<Post> Posts { get; set; }
      

        //public ICollection<Post> RPosts { get; set; }

        public User()
        {
        }

        public User(int id, string name, string email, string phone)
        {
            this.id = id;
            this.name = name;
            Email = email;
            Phone = phone;
            //DOB = dOB;
        }
    }
}
