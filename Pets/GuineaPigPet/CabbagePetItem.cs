using PS3Mod.Content.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Pets.GuineaPigPet
{
	public class CabbagePetItem : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ZephyrFish); // Copy the Defaults of the Zephyr Fish Item.

			Item.shoot = ModContent.ProjectileType<GuineaPigProjectile>(); // "Shoot" your pet projectile.
			Item.buffType = ModContent.BuffType<GuineaPigPetBuff>(); // Apply buff upon usage of the Item.
		}

		public override bool? UseItem(Player player)
		{
			if (player.whoAmI == Main.myPlayer) {
				player.AddBuff(Item.buffType, 3600);
			}
			return true;
		}
	}
}
