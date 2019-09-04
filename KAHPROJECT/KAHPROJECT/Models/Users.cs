﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KAHPROJECT.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public string Password { get; set; }
        public DateTime Date_Created { get; set; }
    }
}
