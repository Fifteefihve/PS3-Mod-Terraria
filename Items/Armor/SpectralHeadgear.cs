using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SpectralHeadgear : ModItem
    {
        public static readonly int MaxManaIncrease = 100;
		public static readonly int MagicDamagePercent = 10;
		public static readonly int MagicCritPercent = 10;
		public static readonly int SetBonusManaCostReductionPercent = 23;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MaxManaIncrease, MagicDamagePercent);
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = Item.sellPrice(gold: 10);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += MaxManaIncrease;
			player.GetDamage(DamageClass.Magic) += MagicDamagePercent / 100f;
			player.GetCritChance(DamageClass.Magic) += MagicCritPercent;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = $"{SetBonusManaCostReductionPercent}% reduced mana usage";
			player.manaCost -= SetBonusManaCostReductionPercent / 100f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
			return body.type == ModContent.ItemType<SpectralArmor>() && legs.type == ModContent.ItemType<SpectralSubligar>();
		}
    }
}