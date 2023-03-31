using NovaksMod.Content.Projectiles.FlamingoSword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Items.Weapons.Melee
{
    internal class FlamingoSpinningSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flamingo?");
            Tooltip.SetDefault("Flamingo?");
        }
        public override void SetDefaults()
        {
            Item.SetWeaponValues(25, 2);

            Item.width = 32;
            Item.height = 48;

            Item.useTime = 4;
            Item.useAnimation = Item.useTime;
            Item.useStyle = ItemUseStyleID.HoldUp;

            Item.noMelee = true;
            Item.noUseGraphic = false;
            Item.channel = true;
            Item.autoReuse = true;

            Item.shootSpeed = 20f;
            Item.shoot = ModContent.ProjectileType<FlamingoSwordProjectile>();
        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }
    }
}
