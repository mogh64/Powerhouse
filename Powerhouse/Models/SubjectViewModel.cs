using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Powerhouse.Models
{
    public class SubjectViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public int CategoryId { get; set; }
    }
}