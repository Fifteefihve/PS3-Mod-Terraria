using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PS3Mod.Content.Items
{
    public class OldTNE : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TrueNightsEdge)
            {
                //item.shoot = ModContent.ProjectileType<OldTNE>();
                item.shootSpeed = 1.5f;
            }
        }
    }
}