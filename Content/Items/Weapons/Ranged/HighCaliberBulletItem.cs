using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaksMod.Content.Projectiles.HighCaliberBullet;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Items.Weapons.Ranged
{
    internal class HighCaliberBulletItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("High Caliber Bullet");
            Tooltip.SetDefault("A bullet of a higher caliber.");
        }
        public override void SetDefaults()
        {
            Item.damage = 29;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 5; Item.height = 9;
            Item.scale = 2;
            Item.useTime = 20;
            Item.maxStack = 999;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 4;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = 2;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<HighCaliberBulletProjectile>();
            Item.shootSpeed = 16f;
            Item.ammo = AmmoID.Bullet;
            Item.useAmmo = ModContent.ItemType<HighCaliberBulletItem>();
            Item.consumable = true;
        }
    }
}
