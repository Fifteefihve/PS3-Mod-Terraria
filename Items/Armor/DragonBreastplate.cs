using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class DragonBreastplate : ModItem
    {
        public static readonly int CritChancePercent = 10;
		public static readonly int MeleeDamagePercent = 5;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritChancePercent, MeleeDamagePercent);
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 20);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetCritChance(DamageClass.Generic) += CritChancePercent;
			player.GetDamage(DamageClass.Melee) += MeleeDamagePercent / 100f;
        }
    }
}