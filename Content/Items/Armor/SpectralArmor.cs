using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.SpectralArmor
{
    [AutoloadEquip(EquipType.Body)]
    public class SpectralArmor : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 20);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Magic) += 0.05f;
            player.GetCritChance(DamageClass.Magic) += 10f;
            player.manaCost -= 0.10f;
        }
    }
}