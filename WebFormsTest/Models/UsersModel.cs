﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsTest.Models
{
    public class UsersModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
    }
}
