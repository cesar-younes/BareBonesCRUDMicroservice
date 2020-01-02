using BareBonesCRUDMicroservice.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesCRUDMicroservice.Data
{
    public class BareBonesCRUDContextSeed
    {
        public static async Task SeedAsync(BareBonesCRUDContext context, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                if (!context.BareBonesCRUDItems.Any())
                {
                    context.BareBonesCRUDItems.AddRange(GetPreconfiguredItems());

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<BareBonesCRUDContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(context, loggerFactory, retryForAvailability);
                }
            }
        }

        static BareBonesCRUDItem[] GetPreconfiguredItems()
        {
            BareBonesCRUDItem[] items = new BareBonesCRUDItem[3];
            items[0] = new BareBonesCRUDItem
            {
                Name = "A",
                Status = ItemStatus.New,
                Items = new List<SubBareBonesCRUDItem>() { 
                    new SubBareBonesCRUDItem()
                    {
                        Timestamp = DateTime.Now,
                    }
                }
            };
            items[1] = new BareBonesCRUDItem
            {
                Name = "B",
                Status = ItemStatus.Accepted,
                Items = new List<SubBareBonesCRUDItem>() {
                    new SubBareBonesCRUDItem()
                    {
                        Timestamp = DateTime.Now,
                    }
                }
            };                                         
            items[2] = new BareBonesCRUDItem           
            {                                          
                Name = "C",                            
                Status = ItemStatus.Deleted,
                Items = new List<SubBareBonesCRUDItem>() {
                    new SubBareBonesCRUDItem()
                    {
                        Timestamp = DateTime.Now,
                    }
                }
            };
            return items;
        }
    }
}
