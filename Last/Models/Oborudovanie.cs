using System;
using System.Collections.Generic;

namespace Last.Models
{
    public partial class Oborudovanie
    {
        public Oborudovanie()
        {
            Zayavkis = new HashSet<Zayavki>();
        }

        public int IdObor { get; set; }
        public string TitleObor { get; set; } = null!;

        public virtual ICollection<Zayavki> Zayavkis { get; set; }
    }
}
