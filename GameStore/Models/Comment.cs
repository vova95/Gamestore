using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string login { get; set; }
        public string text { get; set; }
    }
}