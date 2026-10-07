using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PS3Mod.Content.Items
{
    public class OldTerraBlade : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            // Only affect the vanilla Terra Blade
            if (item.type == ItemID.TerraBlade)
            {
                // Point it at our custom projectile
                item.shoot = ModContent.ProjectileType<OldTerraBeam>();
                item.shootSpeed = 1.5f;
            }
        }
    }
}