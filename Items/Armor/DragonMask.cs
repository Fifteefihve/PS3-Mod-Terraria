using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DragonMask : ModItem
    {
		public static readonly int MeleeSpeedAndDamagePercent = 15;
		public static readonly int CritChancePercent = 15;

		public static readonly int SetBonusSpeedPercent = 21;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MeleeSpeedAndDamagePercent, CritChancePercent);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.value = Item.sellPrice(gold: 10);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 26;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) += MeleeSpeedAndDamagePercent / 100f;
			player.GetAttackSpeed(DamageClass.Melee) += MeleeSpeedAndDamagePercent / 100f;
			player.GetCritChance(DamageClass.Generic) += CritChancePercent;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
			return body.type == ModContent.ItemType<DragonGreaves>() && legs.type == ModContent.ItemType<DragonMask>();
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = $"{SetBonusSpeedPercent}% increased melee speed and movement speed";
			player.GetAttackSpeed(DamageClass.Melee) += SetBonusSpeedPercent / 100f;
			player.moveSpeed += SetBonusSpeedPercent / 100f;
		}

        // public override void AddRecipes() {
		// 	CreateRecipe().AddIngredient<ExampleItem>()
		// 		.AddTile<Tiles.Furniture.ExampleWorkbench>()
		// 		.Register();
		// }
    }
}