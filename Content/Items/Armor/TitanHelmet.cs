using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.TitanHelmet
{
    [AutoloadEquip(EquipType.Head)]
    public class TitanHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.value = Item.sellPrice(gold: 10);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 14;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Ranged) += 0.15f;
            player.GetCritChance(DamageClass.Ranged) += 10f;

            player.ammoBox = true;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "28% chance not to consume ammo";

            player.ammoBox = true;
        }
    }
}
