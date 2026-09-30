using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.DragonBreastplate
{
    [AutoloadEquip(EquipType.Body)]
    public class DragonBreastplate : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 20);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) += 0.05f;
            player.GetCritChance(DamageClass.Melee) += 5f;
        }
    }
}