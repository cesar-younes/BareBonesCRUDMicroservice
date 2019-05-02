using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesMicroservice.Model
{
    public class BareBonesCRUDItem : BaseEntity
    {
        [NotMapped]
        public List<string> Items { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public BareBonesCRUDItem()
        {
            Items = new List<string>();
        }
    }
}
