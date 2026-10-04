using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class SpectralArmor : ModItem
    {
        public static readonly int MagicDamagePercent = 5;
		public static readonly int ManaCostReductionPercent = 10;
		public static readonly int MagicCritPercent = 10;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MagicDamagePercent, ManaCostReductionPercent, MagicCritPercent);
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 28;
            Item.value = Item.sellPrice(gold: 20);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Magic) += MagicDamagePercent / 100f;
			player.manaCost -= ManaCostReductionPercent / 100f;
			player.GetCritChance(DamageClass.Magic) += MagicCritPercent;
        }
    }
}