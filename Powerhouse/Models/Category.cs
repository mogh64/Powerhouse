﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Powerhouse.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Title { get; set; }       
        public int Order { get; set; }
    }
}