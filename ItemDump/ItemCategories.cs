using System.Linq;

namespace DataDumper.ItemDump;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Newtonsoft.Json;

public class ItemCategories
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Accessory { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Ammunition { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Armor { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? BackgroundObject { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Bait { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Banner { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Bar { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Block { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? BossSummon { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Consumable { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? CraftingMaterial { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Crate { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Critter { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Dye { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? EventSummon { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Food { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Furniture { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Gem { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? GrabBag { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? HairDye { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Hook { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? ItemSummon { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Key { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Kite { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? LightPet { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? LightSource { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Mechanism { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Miscellaneous { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? MountSummon { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? NoCategory { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Ore { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Paint { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? PetSummon { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Platform { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Potion { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Pylon { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? QuestFish { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Relic { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Seeds { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Shield { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Statues { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Tool { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Torch { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Painting { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Vanity { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Wall { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Weapon { get; set; }

    // Weapon Sub-groups
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Boomerang { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Bow { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Flail { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Gun { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Launcher { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Repeater { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Spear { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Sword { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Whip { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Yoyo { get; set; }

    // Furniture Sub-groups
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Bathtub { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Bed { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Bookcase { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Candelabra { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Candle { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Chair { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Chandelier { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Chest { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Clock { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Door { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Dresser { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Lamp { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Lantern { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Piano { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Sink { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Sofa { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Table { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Toilet { get; set; }

    public ItemCategories(Item item)
    {
        bool any = false;

        // General Basic Flags
        if (item.accessory)
        {
            Accessory = true;
            any = true;
        }

        if (item.ammo != AmmoID.None)
        {
            Ammunition = true;
            any = true;
        }

        if (item.headSlot != -1 || item.bodySlot != -1 || item.legSlot != -1)
        {
            Armor = true;
            any = true;
        }

        if (item.bait > 0)
        {
            Bait = true;
            any = true;
        }

        if (item.consumable)
        {
            Consumable = true;
            any = true;
        }

        if (item.material)
        {
            CraftingMaterial = true;
            any = true;
        }

        if (item.dye > 0)
        {
            Dye = true;
            any = true;
        }

        if (item.hairDye != -1)
        {
            HairDye = true;
            any = true;
        }

        if (item.questItem)
        {
            QuestFish = true;
            any = true;
        }

        if (item.vanity)
        {
            Vanity = true;
            any = true;
        }

        if (item.paint > 0)
        {
            Paint = true;
            any = true;
        }

        if (item.mech)
        {
            Mechanism = true;
            any = true;
        }

        if (item.mountType != -1)
        {
            MountSummon = true;
            any = true;
        }

        if (ItemID.Sets.IsFishingCrate[item.type])
        {
            Crate = true;
            any = true;
        }

        // TODO: do something with this
        if (item.type is ItemID.Amethyst or ItemID.Topaz or ItemID.Sapphire or ItemID.Emerald or ItemID.Ruby or ItemID.Diamond or ItemID.Amber)
        {
            Gem = true;
            any = true;
        }

        if (ItemID.Sets.SortingPriorityBossSpawns[item.type] != -1)
        {
            BossSummon = true;
            any = true;
        }

        if (item.makeNPC > 0)
        {
            Critter = true;
            any = true;
        }

        // Logic-based General
        if (item.damage > 0 && item.useStyle != ItemUseStyleID.None && !item.accessory)
        {
            Weapon = true;
            any = true;
        }

        if (item.pick > 0 || item.axe > 0 || item.hammer > 0)
        {
            Tool = true;
            any = true;
        }

        if (item.buffType > 0 && Main.vanityPet[item.buffType])
        {
            PetSummon = true;
            any = true;
        }

        if (item.buffType > 0 && Main.lightPet[item.buffType])
        {
            LightPet = true;
            any = true;
        }

        if (item.shoot > 0 && Main.projHook[item.shoot])
        {
            Hook = true;
            any = true;
        }

        // Tiles and Walls
        if (item.createWall != -1)
        {
            Wall = true;
            any = true;
        }

        if (item.createTile != -1)
        {
            any = true;
            int t = item.createTile;

            if (TileID.MetalBars == t) Bar = true;
            if (Main.tileSolid[t] && !Main.tileFrameImportant[t]) Block = true;
            if (TileID.Sets.Platforms[t]) Platform = true;
            if (TileID.Sets.Torch[t]) Torch = true;
            if (TileID.MasterTrophyBase == t) Relic = true;
            if (TileID.Sets.CountsAsPylon.Contains(t)) Pylon = true;
            if (t == TileID.Banners) Banner = true;
            if (t == TileID.Statues) Statues = true;
            if (t is TileID.Painting2X3 or TileID.Painting3X2 or TileID.Painting3X3 or TileID.Painting4X3 or TileID.Painting6X4) Painting = true;
            if (TileID.Sets.Ore[t]) Ore = true;

            if (Main.tileFrameImportant[t] && !Block == true && !Platform == true)
            {
                Furniture = true;
                if (TileID.Sets.RoomNeeds.CountsAsChair.Contains(t)) Chair = true;
                if (TileID.Sets.RoomNeeds.CountsAsTable.Contains(t)) Table = true;
                if (TileID.Sets.IsAContainer[t]) Chest = true;
                if (t == TileID.Beds) Bed = true;
                if (t == TileID.Bathtubs) Bathtub = true;
                if (t == TileID.Bookcases) Bookcase = true;
                if (t == TileID.Candelabras) Candelabra = true;
                if (t == TileID.Candles) Candle = true;
                if (t == TileID.Chandeliers) Chandelier = true;
                if (t == TileID.GrandfatherClocks) Clock = true;
                if (TileID.Sets.OpenDoorID[t] != -1 || t == TileID.ClosedDoor) Door = true;
                if (t == TileID.Dressers) Dresser = true;
                if (t == TileID.Lamps) Lamp = true;
                if (t == TileID.HangingLanterns) Lantern = true;
                if (t == TileID.Pianos) Piano = true;
                if (t == TileID.Sinks) Sink = true;
                if (t == TileID.Benches) Sofa = true;
                if (t == TileID.Toilets) Toilet = true;
            }
        }

        // Weapon Subs
        if (Weapon == true)
        {
            if (item.CountsAsClass(DamageClass.Melee) && item.useStyle == ItemUseStyleID.Swing &&
                item.shoot == ProjectileID.None) Sword = true;
            if (item.useAmmo == AmmoID.Arrow) Bow = true;
            if (item.useAmmo == AmmoID.Bullet) Gun = true;
            if (item.useAmmo == AmmoID.Rocket) Launcher = true;
            if (item.useAmmo == AmmoID.Arrow && item.useStyle == ItemUseStyleID.Shoot) Repeater = true;
            if (ItemID.Sets.Yoyo[item.type]) Yoyo = true;
            if (item.useStyle == ItemUseStyleID.Thrust && item.shoot != ProjectileID.None) Spear = true;
            if (item.CountsAsClass(DamageClass.SummonMeleeSpeed)) Whip = true;
            if (item.shoot > 0)
            {
                int ai = ContentSamples.ProjectilesByType[item.shoot].aiStyle;
                if (ai == 3) Boomerang = true;
                if (ai == 15) Flail = true;
            }
        }

        // Catch-alls
        if (!any && item.maxStack > 1 && item.value > 0)
        {
            Miscellaneous = true;
            any = true;
        }

        if (!any) NoCategory = true;
    }
}