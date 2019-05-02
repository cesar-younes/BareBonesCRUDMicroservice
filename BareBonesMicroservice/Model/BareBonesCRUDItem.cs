using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesMicroservice.Model
{
    public class BareBonesCRUDItem : BaseEntity
    {
        //TODO: Change this to a type EF accepts. For now I'm ignoring it.
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
