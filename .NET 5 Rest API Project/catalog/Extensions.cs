using catalog.Dtos;
using catalog.Entities;

namespace catalog
{
    public static class Extensions{
        //this method receives an item and returns its ItemDto version.
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto{
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}