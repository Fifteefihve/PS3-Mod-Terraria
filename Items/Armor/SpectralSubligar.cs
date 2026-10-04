using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class SpectralSubligar : ModItem
    {
        public static readonly int MoveSpeedAndMagicDamagePercent = 10;
		public static readonly int MaxManaIncrease = 20;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeedAndMagicDamagePercent, MaxManaIncrease);
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 15);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += MoveSpeedAndMagicDamagePercent / 100f;
			player.GetDamage(DamageClass.Magic) += MoveSpeedAndMagicDamagePercent / 100f;
			player.statManaMax2 += MaxManaIncrease;
        }
    }
}