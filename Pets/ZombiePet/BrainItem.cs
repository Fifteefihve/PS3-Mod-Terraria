using PS3Mod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Pets.ZombiePet
{
	public class BrainItem : ModItem
	{
		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.ZephyrFish); // Copy the Defaults of the Zephyr Fish Item.

			Item.shoot = ModContent.ProjectileType<ZombiePetProjectile>(); // "Shoot" your pet projectile.
			Item.buffType = ModContent.BuffType<ZombiePetBuff>(); // Apply buff upon usage of the Item.
		}

		public override bool? UseItem(Player player) {
			if (player.whoAmI == Main.myPlayer) {
				player.AddBuff(Item.buffType, 3600);
			}
			return true;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		// public override void AddRecipes() {
		// 	CreateRecipe()
		// 		.AddIngredient<WolfFang>()
		// 		.AddTile<Tiles.Furniture.ExampleWorkbench>()
		// 		.Register();
		// }
	}
}
