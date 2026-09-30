using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.TitanLeggings
{
    [AutoloadEquip(EquipType.Legs)]
    public class TitanLeggings : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 15);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 13;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.10f;
            player.GetDamage(DamageClass.Ranged) += 0.10f;

            player.ammoBox = true;
        }
    }
}