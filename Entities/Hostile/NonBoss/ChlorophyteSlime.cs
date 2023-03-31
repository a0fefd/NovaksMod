using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace NovaksMod.Entities.Hostile.NonBoss
{
    internal class ChlorophyteSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clorophyte Slime");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];
        }
        public override void SetDefaults()
        {
            NPC.width = 32; NPC.height = 15;
            NPC.damage = 25;
            NPC.defense = 20;
            NPC.lifeMax = 200;
            NPC.value = Item.sellPrice(silver: 1);
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.GreenSlime;
            AnimationType = NPCID.GreenSlime;
            NPC.friendly = false;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.PlanteraDefeated)
            {
                return SpawnCondition.UndergroundJungle.Chance * 0.20f;
            }
            return 0f;
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
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Gel, Main.rand.Next(0, 2));
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.ChlorophyteOre, Main.rand.Next(1, 5));
        }
    }
}
