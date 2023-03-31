using NovaksMod.Content.Entities.Hostile.MiniBoss.GemstoneGolem;
using rail;
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
    internal class ModGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            //The if (Main.rand.Next(x) == 0) determines how rare the drop is. To find the percent of a drop, divide 100 by your desired percent, minus the percent sign. Ex: A 2% chance would be 100% / 2%, or 50. This is what you put in place of x.

        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Merchant)
            {
                Item i = new Item(ModContent.ItemType<GemGauntlet>(), 30);
                shop.AddItemToShop(i);
            }
        }
    }
}
