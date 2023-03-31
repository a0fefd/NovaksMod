using NovaksMod.Content.Items.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Items.Accessories
{
    internal class PowerofDestruction : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Power of Destruction");
            Tooltip.SetDefault(
                "Gives you the power to destroy everyone.\n" +
                "Sword of Destruction only does 7 hp damage every swing\n" +
                "Gives you the true speed of a Master\n" +
                "Makes you dodge every hit."
                );

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 16; Item.height = 16;
            Item.master = true; Item.masterOnly = true;
            Item.defense = 200;
            Item.value = Item.sellPrice(platinum: 250);
            Item.rare = ItemRarityID.Master;
            Item.accessory = true;
            Item.stack = 1;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.ClearBuff(BuffID.Frostburn);
            player.ClearBuff(BuffID.Frostburn2);
            player.ClearBuff(BuffID.Burning);
            player.ClearBuff(BuffID.CursedInferno);

            player.ShadowDodge();
            //player.onHitDodge = true;

            player.maxRunSpeed = 1000;
            player.accRunSpeed = 65;
        }
        public override void AddRecipes()
        {
            Recipe r1 = CreateRecipe();
            r1.AddIngredient(ModContent.ItemType<TrueSpeed>());
            r1.AddIngredient(ItemID.LunarBar, 50);
            r1.AddIngredient(ItemID.FragmentNebula, 100);
            r1.AddIngredient(ItemID.FragmentSolar, 100);
            r1.AddIngredient(ItemID.FragmentStardust, 100);
            r1.AddIngredient(ItemID.FragmentVortex, 100);
            r1.AddTile(TileID.LunarCraftingStation);

            Recipe r2 = CreateRecipe();
            r2.AddIngredient(ModContent.ItemType<TrueSpeed>());
            r2.AddIngredient(ModContent.ItemType<GodlySpirit>());
            r2.AddTile(TileID.LunarCraftingStation);

            r1.Register();
            r2.Register();
        }
    }
}
