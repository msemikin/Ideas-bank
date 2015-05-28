using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IdeasBank.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> IdeaId { get; set; }
        public string Text { get; set; }
        public string ImplementationInfo { get; set; }
    }
}