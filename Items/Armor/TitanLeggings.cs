using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class TitanLeggings : ModItem
    {
        public static readonly int MoveSpeedAndRangedDamagePercent = 10;
		public static readonly int NoAmmoChancePercent = 5;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeedAndRangedDamagePercent, NoAmmoChancePercent);
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 15);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 13;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += MoveSpeedAndRangedDamagePercent / 100f;
			player.GetDamage(DamageClass.Ranged) += MoveSpeedAndRangedDamagePercent / 100f;
			player.GetModPlayer<TitanArmorPlayer>().NoAmmoConsumeChance += NoAmmoChancePercent / 100f;
        }
    }
}