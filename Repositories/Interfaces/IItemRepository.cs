using projeto.Models;

namespace projeto.Repositories.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> Itens{get;}
        IEnumerable<Item> ItensEmDestaque{get;}
        Item GetItemById(int itemId);
    }
}