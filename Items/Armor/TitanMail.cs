using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class TitanMail : ModItem
    {
        public static readonly int RangedDamagePercent = 5;
		public static readonly int NoAmmoChancePercent = 5;
		public static readonly int RangedCritPercent = 10;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(RangedDamagePercent, NoAmmoChancePercent, RangedCritPercent);
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.value = Item.sellPrice(gold: 20);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 18;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Ranged) += RangedDamagePercent / 100f;
			player.GetCritChance(DamageClass.Ranged) += RangedCritPercent;
			player.GetModPlayer<TitanArmorPlayer>().NoAmmoConsumeChance += NoAmmoChancePercent / 100f;
        }
    }
}
