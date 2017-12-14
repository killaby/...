﻿using System;
using System.Collections.Generic;


namespace CodeFirstDemo.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string  Password { get; set; }

        public ICollection<Post> Posts  { get; set; }

        public ICollection<Reply> Replies { get; set; }
    }
}
