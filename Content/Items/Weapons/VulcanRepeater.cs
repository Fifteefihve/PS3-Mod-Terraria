using PS3Mod.Content.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Weapons
{
    public class VulcanRepeater : ModItem
    {
        public override void SetDefaults()
        {
            // Modders can use Item.DefaultToRangedWeapon to quickly set many common properties, such as: useTime, useAnimation, useStyle, autoReuse, DamageType, shoot, shootSpeed, useAmmo, and noMelee. These are all shown individually here for teaching purposes.

            // Common Properties
            Item.width = 52; // Hitbox width of the item.
            Item.height = 20; // Hitbox height of the item.
            Item.scale = 1f;
            Item.rare = ItemRarityID.Pink; // The color that the item's name will be in-game.

            // Use Properties
            Item.useTime = 17; // The item's use time in ticks (60 ticks == 1 second.)
            Item.useAnimation = 17; // The length of the item's use animation in ticks (60 ticks == 1 second.)
            Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
            Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.

            // Weapon Properties
            Item.shootSpeed = 10f; // higher = faster
            Item.DamageType = DamageClass.Ranged; // Sets the damage type to ranged.
            Item.damage = 56; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
            Item.crit = 4;
            Item.knockBack = 2.5f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
            Item.noMelee = true; // So the item's animation doesn't do damage.

            // Gun Properties
            Item.shoot = ProjectileID.PurificationPowder; // For some reason, all the guns in the vanilla source have this.
            Item.useAmmo = AmmoID.Arrow; // The "ammo Id" of the ammo item that this weapon uses. Ammo IDs are magic numbers that usually correspond to the item id of one item that most commonly represent the ammo type.
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
                type = ModContent.ProjectileType<Projectiles.VulcanBoltProjectile>();
            }
        }
    }
}