using PS3Mod.Content.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Weapons
{
    public class Sharanga : ModItem
    {
        public override void SetDefaults()
        {
            // Modders can use Item.DefaultToRangedWeapon to quickly set many common properties, such as: useTime, useAnimation, useStyle, autoReuse, DamageType, shoot, shootSpeed, useAmmo, and noMelee. These are all shown individually here for teaching purposes.

            // Common Properties
            Item.width = 18; // Hitbox width of the item.
            Item.height = 40; // Hitbox height of the item.
            Item.scale = 1f;
            Item.rare = ItemRarityID.Pink; // The color that the item's name will be in-game.

            // Use Properties
            Item.useTime = 20; // The item's use time in ticks (60 ticks == 1 second.)
            Item.useAnimation = 20; // The length of the item's use animation in ticks (60 ticks == 1 second.)
            Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
            Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.

            // Weapon Properties
            Item.DamageType = DamageClass.Ranged; // Sets the damage type to ranged.
            Item.crit = 4;
            Item.damage = 36; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
            Item.knockBack = 2f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
            Item.noMelee = true; // So the item's animation doesn't do damage.

            // Gun Properties
            Item.shoot = ProjectileID.PurificationPowder; // For some reason, all the guns in the vanilla source have this.
            Item.shootSpeed = 10f; // The speed of the projectile (measured in pixels per frame.) This value equivalent to Handgun
            Item.useAmmo = AmmoID.Arrow; // The "ammo Id" of the ammo item that this weapon uses. Ammo IDs are magic numbers that usually correspond to the item id of one item that most commonly represent the ammo type.
            Item.UseSound = SoundID.Item5; // The sound that this item plays when used.

        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        //public override void AddRecipes()
        //{
        //    CreateRecipe()
        //        .AddIngredient<ExampleItem>()
        //        .AddTile<Tiles.Furniture.ExampleWorkbench>()
        //        .Register();
        //}


        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = ModContent.ProjectileType<Projectiles.SpectralArrowProjectile>();
            }
        }
    }
}