using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Items.Materials
{
    internal class GodlySpirit : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The spirit of a god.");

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }
        public override void SetDefaults()
        {
            Item.width = 15; Item.height = 16;
            Item.material = true;
            Item.master = true;
            Item.maxStack = 3;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Purple;
        }
    }
}
