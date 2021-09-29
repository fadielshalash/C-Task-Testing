using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    [Table("Posts")]
    public class Post:IBM
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string title { get; set; }
        public string body { get; set; }
       
        [ForeignKey("user1")]
        public int UserId { get; set; }

        [InverseProperty("Posts")]
        public User user { get; set; }

        public Post(int id, string title, string body, int userId)
        {
            this.id = id;
            this.title = title;
            this.body = body;
            UserId = userId;
        }

        public Post()
        {
        }


        //[ForeignKey("RUser")]
        //public int RUserId { get; set; }
        //[InverseProperty("RPosts")]
        //public User Ruser { get; set; }
    }
}
