using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Weapons
{
	public class Tizona : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 48;
			Item.height = 48;
            Item.scale = 1.2f;

            Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 55;
			Item.knockBack = 5;
			Item.crit = 4;

			Item.value = Item.buyPrice(gold: 6);
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.ResearchUnlockCount = 1;
            Item.rare = ItemRarityID.Pink;
        }
	}
}