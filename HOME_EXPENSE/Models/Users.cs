﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOME_EXPENSE.Models
{
    public class Users
    {
        public int UserID {get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }


    }
}