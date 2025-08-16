namespace Overkill.Domains.Crafting;

public class Inventory
{
    private readonly List<(CraftItem, CraftItem)> _list = [];

    public List<(CraftItem, CraftItem)> GetPairedItems()
    {
        return _list;
    }

    public List<(CraftItem, CraftItem)> GetItemsInPriceRange(decimal minPrice, decimal maxPrice)
    {
        return _list.Where(item =>
            {
                var sumItem = item.Item1 with { Price = item.Item1.Price + item.Item2.Price };
                return sumItem.Price >= minPrice && sumItem.Price <= maxPrice;
            }
        ).ToList();
    }

    public void AddPairedItems(CraftItem item1, CraftItem item2)
    {
        _list.Add((item1, item2));
    }
}
