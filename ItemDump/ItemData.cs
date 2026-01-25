using Terraria;
using Terraria.ID;

namespace DataDumper.ItemDump;

public class ItemData
{
    public int Id;
    
    public string InternalName;

    public string Name;

    public int Value;

    public int Rarity;

    public ItemCategories Categories;

    public ItemData(Item item, int id)
    {
        Id = id;
        InternalName = ItemID.Search.GetName(id);
        Name = Lang.GetItemNameValue(id);
        Value = item.value;
        Categories = new ItemCategories(item);

    }

}