using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public class Like
    {
        public int IdeaId { get; set; }

        public int UserId { get; set; }
    }
}