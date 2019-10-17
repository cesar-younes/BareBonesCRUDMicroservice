using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesCRUDMicroservice.Model
{
    public class BareBonesCRUDItem : BaseEntity
    {
        //TODO: Change this to a type EF accepts. For now I'm ignoring it.
        public List<SubBareBonesCRUDItem> Items { get; set; }
        [Required]
        public string Name { get; set; }
        public string Status { get; set; }

        public BareBonesCRUDItem()
        {
            Items = new List<SubBareBonesCRUDItem>();
        }
    }
}
