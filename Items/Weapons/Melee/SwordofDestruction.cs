using Terraria;
using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using NovaksMod.Items.Materials;

namespace NovaksMod.Items.Weapons.Melee
{
    internal class SwordofDestruction : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sword of Destruction");
            Tooltip.SetDefault(
                "Be careful with the power you weild...\n" +
                "You lose ~300 hp after swinging the sword."
                );

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 20; Item.height = 26;
            Item.master = true; Item.master = true;
            Item.SetWeaponValues(600, 10000, 90);
            Item.DamageType = DamageClass.Melee;
            Item.stack = 1;
            Item.rare = ItemRarityID.Expert;
            Item.value = Item.sellPrice(platinum: 99);

            Item.scale = 1; 

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 15;
            Item.attackSpeedOnlyAffectsWeaponAnimation = true;
            Item.autoReuse = false;

            Item.DamageType = DamageClass.Melee;
            Item.UseSound = SoundID.Item1;

            Item.shoot = ProjectileID.NebulaBlaze1;
            Item.shootSpeed = 10f;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int numberProjectiles = 6;
            float rotation = MathHelper.ToRadians(20);

            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(velocity.X, velocity.Y);
                Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
            }
            player.AddBuff(BuffID.Frostburn, 90);
            player.AddBuff(BuffID.Frostburn2, 90);
            player.AddBuff(BuffID.Burning, 90);
            player.AddBuff(BuffID.CursedInferno, 90);

            return false;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BrokenHeroSword)
                .AddIngredient(ModContent.ItemType<GodlySpirit>(), 3)
                .AddTile(TileID.LunarCraftingStation)
                .AddCondition(Recipe.Condition.InRain)
                .Register();
        }
    }
}