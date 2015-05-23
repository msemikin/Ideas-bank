using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public class IdeasBankDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Idea> Ideas { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<Subscribe> Subscribes{ get; set; }

        public DbSet<User> Users { get; set; }
    }
}