using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public class Idea
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descriprion { get; set; }

        public int AuthorId { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

    }
}