using System.ComponentModel.DataAnnotations;

namespace BareBonesCRUDMicroservice.Model
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
    }
}
