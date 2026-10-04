using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class DragonGreaves : ModItem
    {
        public static readonly int MoveSpeedPercent = 12;
		public static readonly int MeleeSpeedPercent = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeedPercent, MeleeSpeedPercent);
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 15);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 14;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += MoveSpeedPercent / 100f;
			player.GetAttackSpeed(DamageClass.Melee) += MeleeSpeedPercent / 100f;
        }

        
    }
}