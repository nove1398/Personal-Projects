using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Preggers_Jam.Models
{
    class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsActive { get; set; }



        public static List<Blog> SeedBlogs = new List<Blog>()
        {
            new Blog(){BlogId = 1, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 1", Description = "This blog is used to talk about this awesome topic right now, this topic is so good it had to be talked about", IsActive = true, UserId = 1 },
            new Blog(){BlogId = 2, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 2", Description = "Description blog", IsActive = true, UserId = 1 },
            new Blog(){BlogId = 3, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 3", Description = "Description blog", IsActive = true, UserId = 1 },
            new Blog(){BlogId = 4, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 4", Description = "Description blog", IsActive = true, UserId = 1 },
            new Blog(){BlogId = 5, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 5", Description = "This blog is used to talk about this awesome topic right now, this topic is so good it had to be talked about", IsActive = true, UserId = 1 },
            new Blog(){BlogId = 6, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 6", Description = "Description blog", IsActive = true, UserId = 1 },
            new Blog(){BlogId = 7, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 7", Description = "This blog is used to talk about this awesome topic right now, this topic is so good it had to be talked about", IsActive = true, UserId = 1 },
            new Blog(){BlogId = 8, CreatedAt = DateTime.Now.AddDays(1), Title = "Title 8", Description = "Description blog", IsActive = true, UserId = 1 }

        };
    }
}
