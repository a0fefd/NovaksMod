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
    [AutoloadEquip(EquipType.Body)]
    internal class DiamondInfusedCopperBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Infused Copper Breastplate");
            Tooltip.SetDefault("Increases mining speed by 15%");
        }
        public override void SetDefaults()
        {

            Item.width = 29; Item.height = 19;
            Item.wornArmor = true;
            Item.defense = 5;
        }
        public override void UpdateEquip(Player player)
        {
            player.pickSpeed -= 0.15f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ModContent.ItemType<DiamondInfusedCopperHelmet>() && legs.type == ModContent.ItemType<DiamondInfusedCopperGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Grants no fall damage, and +7% mining speed";
            player.noFallDmg = true;
            player.pickSpeed += 0.07f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<GemstoneAmalgamate>())
                .AddIngredient(ItemID.Diamond, 25)
                .AddIngredient(ItemID.CopperChainmail)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
