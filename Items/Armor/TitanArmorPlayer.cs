using Terraria;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor
{
	// tModLoader has no simple "x% chance not to consume ammo" field, so the Titan pieces
	// add to this value and CanConsumeAmmo rolls it.
	public class TitanArmorPlayer : ModPlayer
	{
		public float NoAmmoConsumeChance; // 0.05f = 5%

		public override void ResetEffects()
		{
			NoAmmoConsumeChance = 0f;
		}

		public override bool CanConsumeAmmo(Item weapon, Item ammo)
		{
			if (NoAmmoConsumeChance > 0f && Main.rand.NextFloat() < NoAmmoConsumeChance)
			{
				return false;
			}
			return true;
		}
	}
}
