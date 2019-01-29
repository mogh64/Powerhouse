﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Powerhouse.Ef
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public int Order { get; set; }

    }
}