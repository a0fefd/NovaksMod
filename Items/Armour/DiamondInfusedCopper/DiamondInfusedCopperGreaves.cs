using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaksMod.Entities.Hostile.MiniBoss.GemstoneGolem;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Items.Armour.DiamondInfusedCopper
{
    [AutoloadEquip(EquipType.Legs)]
    internal class DiamondInfusedCopperGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Infused Copper Greaves");
            Tooltip.SetDefault("Increases walkspeed by 5%");
        }
        public override void SetDefaults()
        {

            Item.width = 29; Item.height = 19;
            Item.wornArmor = true;
            Item.defense = 4;
        }
        public override void UpdateEquip(Player player)
        {
            player.maxRunSpeed += 0.05f;
            player.wallSpeed += 0.05f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<GemstoneAmalgamate>())
                .AddIngredient(ItemID.Diamond, 15)
                .AddIngredient(ItemID.CopperChainmail)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
