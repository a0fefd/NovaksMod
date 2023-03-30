using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Projectiles.HighCaliberBullet
{
    internal class HighCaliberBulletProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {

        }
        public override void SetDefaults()
        {
            Projectile.damage = 29;
            Projectile.width = 7; Projectile.height = 5;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.aiStyle = 1;
            Projectile.extraUpdates = 1;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 400;
            Projectile.scale = 2.25f;
            AIType = ProjectileID.Bullet;
        }
    }
}
