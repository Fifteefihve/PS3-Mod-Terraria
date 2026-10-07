using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PS3Mod.Content.Items
{
    public class OldTerraBeam : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 18;
            Projectile.height = 18;
            Projectile.aiStyle = ProjAIStyleID.Beam;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 300;
            Projectile.light = 0.25f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 1;
            Projectile.scale = 1.2f;
        }

        public override void AI()
        {
            int dust = Dust.NewDust
            (
                new Vector2(Projectile.position.X - Projectile.velocity.X * 4f + 2f,
                            Projectile.position.Y + 2f - Projectile.velocity.Y * 4f),
                8, 8,
                DustID.Terra, // Green dust ID 107
                Projectile.oldVelocity.X,
                Projectile.oldVelocity.Y,
                100,
                default(Color),
                1.25f
            );

            Main.dust[dust].velocity *= -0.25f;
            Main.dust[dust].position -= Projectile.velocity * 0.5f;
        }
    }
}