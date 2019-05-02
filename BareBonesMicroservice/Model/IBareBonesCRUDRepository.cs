using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesMicroservice.Model
{
    public interface IBareBonesCRUDRepository
    {
        List<BareBonesCRUDItem> GetItems();
        Task<BareBonesCRUDItem> PostItemAsync(BareBonesCRUDItem bareBonesItem);
        Task<bool> DeleteItemAsync(string id);
    }
}
