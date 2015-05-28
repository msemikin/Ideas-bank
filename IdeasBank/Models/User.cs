using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginType { get; set; }
        public Nullable<int> InsideServiceId { get; set; }
        public string Email { get; set; }
    }

}