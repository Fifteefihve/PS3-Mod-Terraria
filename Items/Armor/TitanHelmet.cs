using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class TitanHelmet : ModItem
    {
        public static readonly int RangedDamagePercent = 10;
		public static readonly int NoAmmoChancePercent = 5;
		public static readonly int RangedCritPercent = 10;
		public static readonly int SetBonusNoAmmoChancePercent = 28;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(RangedDamagePercent, NoAmmoChancePercent, RangedCritPercent);
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.value = Item.sellPrice(gold: 10);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 14;
        }

		public override void UpdateEquip(Player player)
        {
			player.GetDamage(DamageClass.Ranged) += RangedDamagePercent / 100f;
			player.GetCritChance(DamageClass.Ranged) += RangedCritPercent;
			player.GetModPlayer<TitanArmorPlayer>().NoAmmoConsumeChance += NoAmmoChancePercent / 100f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
        {
			return body.type == ModContent.ItemType<TitanMail>() && legs.type == ModContent.ItemType<TitanLeggings>();
		}

		// Set bonus: 28% extra chance to not consume ammo.
		public override void UpdateArmorSet(Player player)
        {
			player.setBonus = $"{SetBonusNoAmmoChancePercent}% chance to not consume ammo";
			player.GetModPlayer<TitanArmorPlayer>().NoAmmoConsumeChance += SetBonusNoAmmoChancePercent / 100f;
		}
    }
}
