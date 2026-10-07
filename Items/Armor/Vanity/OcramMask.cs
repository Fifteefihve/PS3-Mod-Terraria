using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class OcramMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            int width = 24;
            int height = 26;
            Item.Size = new Vector2(width, height);

            Item.value = Item.sellPrice(silver: 75);
            Item.rare = ItemRarityID.Blue;

            Item.vanity = true;
            Item.maxStack = 1;
        }
    }
}
