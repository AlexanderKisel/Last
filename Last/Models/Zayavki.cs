using System;
using System.Collections.Generic;

namespace Last.Models
{
    public partial class Zayavki
    {
        public int IdZayavki { get; set; }
        public DateTime DateZayavki { get; set; }
        public int OborId { get; set; }
        public int TypeId { get; set; }
        public string? Description { get; set; }
        public int ClientId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? RabId { get; set; }
        public int StatusId { get; set; }

        public virtual User? Client { get; set; }
        public virtual Oborudovanie? Obor { get; set; }
        public virtual User? Rab { get; set; }
        public virtual Status? Status { get; set; }
        public virtual Type? Type { get; set; }
    }
}
