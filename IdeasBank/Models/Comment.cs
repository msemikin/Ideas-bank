using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int IdeaId { get; set; }

        public int UserId { get; set; }

        public string Text { get; set; }
    }
}