using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public partial class Idea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
    }
}