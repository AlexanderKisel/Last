using System;
using System.Collections.Generic;

namespace Last.Models
{
    public partial class Status
    {
        public Status()
        {
            Zayavkis = new HashSet<Zayavki>();
        }

        public int IdStatus { get; set; }
        public string TitleStatus { get; set; } = null!;

        public virtual ICollection<Zayavki> Zayavkis { get; set; }
    }
}
