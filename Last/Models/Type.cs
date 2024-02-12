using System;
using System.Collections.Generic;

namespace Last.Models
{
    public partial class Type
    {
        public Type()
        {
            Zayavkis = new HashSet<Zayavki>();
        }

        public int IdType { get; set; }
        public string TitleType { get; set; } = null!;

        public virtual ICollection<Zayavki> Zayavkis { get; set; }
    }
}
