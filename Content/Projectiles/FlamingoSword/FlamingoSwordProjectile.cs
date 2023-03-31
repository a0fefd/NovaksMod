using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Projectiles.FlamingoSword
{
    internal class FlamingoSwordProjectile : ModProjectile
    {
        Vector2 mw = Main.MouseWorld;
        public override void SetDefaults()
        {

            Projectile.width = 96; Projectile.height = 96;
            
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.friendly = true;
        }

        public override void AI()
        {
            float rot = 25f;
            float num2 = 2f;
            float quarterPi = -(float)Math.PI / 4;

            float scaleFactor = 20f;

            Player player = Main.player[Projectile.owner];

            Vector2 relativePoint = player.RotatedRelativePoint(player.MountedCenter);

            if (player.dead)
            {
                Projectile.Kill();
                return;
            }

            Lighting.AddLight(player.Center, TorchID.Pink);

            Vector2 newPos = mw + new Vector2(Projectile.width/2, 0f);
            Projectile.Center = newPos;

            int sign = Math.Sign(Projectile.velocity.X);

            Projectile.velocity = new Vector2(sign, 0f);

            if (Projectile.ai[0] == 0f)
            {
                Projectile.rotation = new Vector2(sign, 0f - player.gravDir).ToRotation() 
                    + quarterPi 
                    + (float)Math.PI;
                
                if (Projectile.velocity.X < 0f)
                {
                    Projectile.rotation -= (float)Math.PI / 2f;
                }
            }

            Projectile.ai[0] += 1f;

            Projectile.rotation += (float)Math.PI * 2f * num2 / rot * (float)sign;

            bool isDone = Projectile.ai[0] == (rot / 2f);

            if (Main.mouseLeftRelease)
            {
                Projectile.Kill();
            } else
            {
                newPos = mw + new Vector2(Projectile.width / 2, 0f);
                Projectile.Center = newPos;

            }
            /*
            if (Projectile.ai[0] >= 25 || (isDone && !player.controlUseItem))
            {
                Projectile.Kill();
                player.reuseDelay = 2;
            } else if (isDone)
            {
                

                int dir = (player.DirectionTo(mw).X > 0f) ? 1: -1;
                if ((float)dir != Projectile.velocity.X)
                {
                    player.ChangeDir(dir);
                    //Projectile.velocity = player.velocity;
                    Projectile.netUpdate = true;
                    Projectile.rotation -= (float)Math.PI;
                }
            }*/


        }
    }
}
