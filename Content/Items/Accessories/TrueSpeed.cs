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
    internal class TrueSpeed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Speed");
            Tooltip.SetDefault(
                "Gives you the true speed of a Master.\n" +
                "Makes you dodge every hit."
                );

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 16; Item.height = 16;
            Item.master = true; Item.masterOnly = true;
            Item.defense = 0;
            Item.value = Item.sellPrice(platinum: 100);
            Item.rare = ItemRarityID.Master;
            Item.accessory = true;
            Item.stack = 1;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.ShadowDodge();
            player.maxRunSpeed = 1000;
            player.accRunSpeed = 65;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LunarBar, 25)
                .AddIngredient(ItemID.MasterNinjaGear)
                .AddIngredient(ItemID.AncientShadowHelmet)
                .AddIngredient(ItemID.AncientShadowScalemail)
                .AddIngredient(ItemID.AncientShadowGreaves)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
