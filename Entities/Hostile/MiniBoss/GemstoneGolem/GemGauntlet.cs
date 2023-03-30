using Humanizer;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Entities.Hostile.MiniBoss.GemstoneGolem
{
    internal class GemGauntlet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault(
                "Awakens the protecter of gemstones...\n" +
                "Summons the Gemstone Golem."
                );
        }
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.RaiseLamp;
            Item.UseSound = SoundID.Item2;
            Item.maxStack = 30;
            Item.consumable = true;
            Item.value = Item.buyPrice(gold: 1);
        }
        public override bool? UseItem(Player player)
        {
            NPC.NewNPC(player.GetSource_FromThis(), (int)player.itemLocation.X -15, (int)player.itemLocation.Y, ModContent.NPCType<GemstoneGolem>());
            Main.NewText("Test");

            return true;
        }
        public override bool CanUseItem(Player player)
        {
            return !Main.dayTime;
        }
    }
}
