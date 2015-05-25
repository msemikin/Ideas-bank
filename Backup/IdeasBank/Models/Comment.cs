using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IdeasBank.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public DateTime CreationDate { get; set; }

        public int IdeaId { get; set; }

        public string Text { get; set; }

        public string ImplementationInfo { get; set; }
    }
}