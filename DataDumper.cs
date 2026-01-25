using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using DataDumper.ItemDump;
using Newtonsoft.Json.Serialization;

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
            List<ItemData> exportList = new List<ItemData>();
            for (int i = 0; i < ItemID.Count; i++)
            {
                // Instantiate and hydrate the item
                Item item = new Item();
                item.SetDefaults(i);
                if (item.type == 0 || string.IsNullOrEmpty(item.Name))
                {
                    continue;
                }

                ItemData itemDataInstance = new ItemData(item, i);
                exportList.Add(itemDataInstance);
            }

            string jsonOutput = JsonConvert.SerializeObject(exportList, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new  CamelCaseNamingStrategy()
                },
                Formatting = Formatting.Indented,
            });

            // Write to Main.SavePath (Documents/My Games/Terraria/tModLoader)
            string outputPath = Path.Combine(Main.SavePath, "Terraria_Item_Dump.json");
            File.WriteAllText(outputPath, jsonOutput);
        }
    }
}