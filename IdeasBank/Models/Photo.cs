﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeasBank.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public int IdeaId { get; set; }

        public byte[] PhotoByte { get; set; }
    }
}