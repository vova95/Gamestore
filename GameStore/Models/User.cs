﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class User
    {
        public int userId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}