using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesCRUDMicroservice.Model
{
    public class SubBareBonesCRUDItem : BaseEntity
    {
        public DateTime Timestamp { get; set; }

        public int BareBonesCRUDItem { get; set; }
    }
}
