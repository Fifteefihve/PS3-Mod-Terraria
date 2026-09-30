using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.SpectralHeadgear
{
    [AutoloadEquip(EquipType.Head)]
    public class SpectralHeadgear : ModItem
    {
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
            player.statManaMax2 += 120;
            player.GetDamage(DamageClass.Magic) += 0.15f;
            player.GetCritChance(DamageClass.Magic) += 15f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "23% reduced mana usage";
            player.manaCost -= 0.23f;
        }
    }
}