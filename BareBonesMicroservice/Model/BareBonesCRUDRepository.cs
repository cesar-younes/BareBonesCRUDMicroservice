using BareBonesCRUDMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesMicroservice.Model
{
    public class BareBonesCRUDRepository : IBareBonesCRUDRepository
    {
        private BareBonesCRUDContext _context;

        public BareBonesCRUDRepository(BareBonesCRUDContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public List<BareBonesCRUDItem> GetItems()
        {
            return _context.BareBonesCRUDItems.ToList();
        }

        public Task<BareBonesCRUDItem> PostItemAsync(BareBonesCRUDItem bareBonesItem)
        {
            throw new NotImplementedException();
        }
    }
}
