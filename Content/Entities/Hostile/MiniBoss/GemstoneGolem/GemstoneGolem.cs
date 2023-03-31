using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaksMod.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Entities.Hostile.MiniBoss.GemstoneGolem
{
    internal class GemstoneGolem : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];
        }
        public override void SetDefaults()
        {
            NPC.width = 80; NPC.height = 100;
            NPC.damage = 10;
            NPC.defense = 5;
            NPC.lifeMax = 700;
            NPC.value = Item.sellPrice(silver: 1);
            NPC.aiStyle = NPCAIStyleID.Mimic;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.GreenSlime;
            AnimationType = NPCID.Paladin;
            NPC.friendly = false;
            NPC.scale = 1;
            NPC.boss = true;
        }
        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;
            if (NPC.frameCounter >= 20)
            {
                NPC.frameCounter = 0;
            }
            NPC.frame.Y = (int)NPC.frameCounter / 10 * frameHeight;
        }
        public override void OnKill()
        {
            int s1 = Main.rand.Next(0, 6);
            int s2 = Main.rand.Next(0, 6);
            int s3 = Main.rand.Next(0, 6);
            int[] gems = { ItemID.Topaz, ItemID.Diamond, ItemID.Sapphire, ItemID.Emerald, ItemID.Amethyst, ItemID.Amber, ItemID.Ruby };

            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), gems[s1], Main.rand.Next(1, 3));
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), gems[s2], Main.rand.Next(1, 3));
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), gems[s3], Main.rand.Next(1, 3));
            if (Main.rand.Next(0, 5) == 1)
            {
                Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<GemstoneAmalgamate>(), 1);
            }
        }
    }
}
