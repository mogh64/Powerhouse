using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Powerhouse.Ef
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}