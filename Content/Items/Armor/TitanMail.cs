using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.TitanMail
{
    [AutoloadEquip(EquipType.Body)]
    public class TitanMail : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 20);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 18;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Ranged) += 0.05f;
            player.GetCritChance(DamageClass.Ranged) += 10f;

            player.ammoBox = true;
        }
    }
}
