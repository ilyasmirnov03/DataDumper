using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DataDumper
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class DataDumper : Mod
    {
    }

    public class DataDumperSystem : ModSystem
    {
        // Hook into the post-setup phase where all data is ready
        public override void PostSetupContent()
        {
            List<object> exportList = new List<object>();
            for (int i = 0; i < ItemID.Count; i++)
            {
                // Instantiate and hydrate the item
                Item item = new Item();
                item.SetDefaults(i);
                if (item.type == 0 || string.IsNullOrEmpty(item.Name))
                {
                    continue;
                }
                var itemData = new
                {
                    id = i,
                    internalName = ItemID.Search.GetName(i), // The "Source Code" name
                    displayName = Lang.GetItemNameValue(i), // The "In-Game" name
                    stats = new
                    {
                        damage = item.damage,
                        defense = item.defense,
                        crit = item.crit,
                        knockback = item.knockBack,
                        value = item.value, // Sell price in copper coins
                        rarity = item.rare
                    },
                    usage = new
                    {
                        useTime = item.useTime,
                        useAnimation = item.useAnimation,
                        useStyle = item.useStyle,
                        autoReuse = item.autoReuse,
                        consumable = item.consumable,
                        maxStack = item.maxStack
                    },
                    // Extracting from ItemID.Sets (External Arrays)
                    tags = new
                    {
                        isBossBag = ItemID.Sets.BossBag[i],
                        isYoyo = ItemID.Sets.Yoyo[i],
                        isAccessory = item.accessory
                    }
                };
                exportList.Add(itemData);
            }

            string jsonOutput = JsonConvert.SerializeObject(exportList, Formatting.Indented);
            // Write to Main.SavePath (Documents/My Games/Terraria/tModLoader)
            string outputPath = Path.Combine(Main.SavePath, "Terraria_Item_Dump.json");
            File.WriteAllText(outputPath, jsonOutput);
        }
    }
}