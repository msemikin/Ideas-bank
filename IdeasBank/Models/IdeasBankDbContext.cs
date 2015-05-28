using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public class IdeasBankDbContext : DbContext
    {
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Ideas> Ideas { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Subscribes> Subscribes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}