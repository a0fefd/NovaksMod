using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaksMod.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Items.Armour.DiamondInfusedCopper
{
    [AutoloadEquip(EquipType.Head)]
    internal class DiamondInfusedCopperHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Infused Copper Helmet");
        }
        public override void SetDefaults()
        {

            Item.width = 29; Item.height = 19;
            Item.wornArmor = true;
            Item.defense = 4;
        }
        public override void UpdateEquip(Player player)
        {
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<GemstoneAmalgamate>())
                .AddIngredient(ItemID.Diamond, 20)
                .AddIngredient(ItemID.CopperChainmail)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
