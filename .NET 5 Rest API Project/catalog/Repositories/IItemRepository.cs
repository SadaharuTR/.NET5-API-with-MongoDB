using System.Collections.Generic;
using System;
using catalog.Entities;
using System.Threading.Tasks;

namespace catalog.Repositories
{
    public interface IItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item); 
        Task DeleteItemAsync(Guid id);    
    }
}
