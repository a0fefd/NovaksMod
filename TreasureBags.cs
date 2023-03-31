using NovaksMod.Content.Items.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod
{
    public class TreasureBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.MoonLordBossBag && Main.rand.NextBool(50))
            {
                Item.NewItem(player.GetSource_Loot(), player.getRect(), ModContent.ItemType<GodlySpirit>());
            }
        }
    }
}
