using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace PS3Mod.Content.Items
{
    public class SoulofBlight : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.AnimatesAsSoul[Type] = true;
            ItemID.Sets.ItemIconPulse[Type] = true; // The item pulses while in the player's inventory
            ItemID.Sets.ItemNoGravity[Type] = true; // Makes the item have no gravity
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(1, 1));
            Item.ResearchUnlockCount = 25; // Configure the amount of this item that's needed to research it in Journey mode.
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = 1000; // Makes the item worth 1 gold.
            Item.rare = ItemRarityID.Orange;
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale); // Makes this item glow when thrown out of inventory.
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return new Color(255, 255, 255, 50); // Makes this item render at full brightness.
        }
    }
}