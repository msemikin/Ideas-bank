using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public partial class Subscribe
    {
        public int IdeaId { get; set; }
        public int AuthorId { get; set; }
    }

}