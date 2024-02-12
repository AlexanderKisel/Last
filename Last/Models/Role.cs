﻿using System;
using System.Collections.Generic;

namespace Last.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int IdRole { get; set; }
        public string Role1 { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
