using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace NovaksMod.Content.Items.Weapons.Ranged
{
    internal class RapidRevolver : ModItem
    {
        private int shots = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rapid Revolver");
            Tooltip.SetDefault("Faster firing revolver.");
        }
        public override void SetDefaults()
        {
            Item.damage = 4;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 27; Item.height = 27;
            Item.useTime = 11; Item.useAnimation = Item.useTime;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 0.75f;
            Item.value = 2500;
            Item.rare = ItemRarityID.Cyan;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.Bullet;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 6.5f;
            Item.scale = 0.7f;
            Item.noMelee = true;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Vector2 offset = new Vector2(velocity.X * 3, velocity.Y * 3);
            position += offset;

            return true;
        }

    }
}
