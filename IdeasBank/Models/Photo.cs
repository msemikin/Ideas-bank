using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public partial class Photo
    {
        public int Id { get; set; }
        public Nullable<int> IdeaId { get; set; }
        public string PhotoLink { get; set; }
    }
}