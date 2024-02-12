using System;
using System.Collections.Generic;

namespace Last.Models
{
    public partial class User
    {
        public User()
        {
            ZayavkiClients = new HashSet<Zayavki>();
            ZayavkiRabs = new HashSet<Zayavki>();
        }

        public int IdUser { get; set; }
        public string Fio { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Zayavki> ZayavkiClients { get; set; }
        public virtual ICollection<Zayavki> ZayavkiRabs { get; set; }
    }
}
