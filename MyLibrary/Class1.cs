using System;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary
{
    public class Blog
    {
        public string title { get; set; }
        public string content { get; set; }
    }
    public class MyDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}
