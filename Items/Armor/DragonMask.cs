using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PS3Mod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DragonMask : ModItem
    {
        public static readonly int MeleeSpeedPercent = 15; //damage whre???????
        public static readonly int MoveSpeedPercent = 15;
        public static readonly int SetBonusPercent = 21;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeedPercent, MeleeSpeedPercent);
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
            player.GetDamage(DamageClass.Melee) += 0.15f;
            player.GetCritChance(DamageClass.Melee) += 10f;
            player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = $"+{SetBonusPercent}% melee speed and movement speed";
            player.GetAttackSpeed(DamageClass.Melee) += 0.21f;
            player.moveSpeed += 0.21f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<DragonBreastplate>() && legs.type == ModContent.ItemType<DragonGreaves>();
        }

        public override void AddRecipes()
        {
            foreach (int tier3 in new int[] { ItemID.AdamantiteHelmet, ItemID.TitaniumHelmet })
                CreateRecipe()
                    .AddIngredient(ItemID.HallowedMask)
                    .AddIngredient(ItemID.CobaltHelmet)
                    .AddIngredient(ItemID.MythrilHelmet)
                    .AddIngredient(tier3)
                    .AddIngredient<SoulofBlight>(15)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
        }
    }
}