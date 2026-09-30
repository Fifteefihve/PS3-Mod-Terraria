using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.DragonGreaves
{
    [AutoloadEquip(EquipType.Legs)]
    public class DragonGreaves : ModItem
    {
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
            player.moveSpeed += 0.12f;
            player.GetAttackSpeed(DamageClass.Melee) += 0.02f;
        }
    }
}