using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public partial class Like
    {
        public int AuthorId { get; set; }
        public int IdeaId { get; set; }
    }
}