using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.DragonMask
{
    [AutoloadEquip(EquipType.Head)]
    public class DragonMask : ModItem
    {
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
            player.setBonus = "+21% melee speed and movement speed";

            player.GetAttackSpeed(DamageClass.Melee) += 0.21f;
            player.moveSpeed += 0.21f;
        }
    }
}