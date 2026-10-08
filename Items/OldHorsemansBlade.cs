using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items
{
    public class OldHorsemansBlade : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.DamageType = DamageClass.Melee;
            Item.width = 60;
            Item.height = 60;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6f;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.Yellow;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.scale = 1.1f;
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            int damage = (int)(damageDone * 1.5f);

            Vector2 spawnPos = Main.screenPosition;
            switch (Main.rand.Next(4))
            {
                case 0: break;
                case 1: spawnPos += new Vector2(Main.screenWidth, 0f); break;
                case 2: spawnPos += new Vector2(0f, Main.screenHeight); break;
                case 3: spawnPos += new Vector2(Main.screenWidth, Main.screenHeight); break;
            }

            Vector2 velocity = Vector2.Normalize(target.Center - spawnPos) * 10f;

            Projectile.NewProjectile(player.GetSource_OnHit(target), spawnPos, velocity,
                ProjectileID.FlamingJack, damage, Item.knockBack, player.whoAmI);
        }

        //Draws the dropped item at full brightness, even in the dark
        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor,
            ref float rotation, ref float scale, int whoAmI)
        {
            Texture2D texture = TextureAssets.Item[Item.type].Value;
            Vector2 position = Item.Center - Main.screenPosition;
            Vector2 origin = texture.Size() / 2f;
            spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, scale, SpriteEffects.None, 0f);
            return false;
        }

        public override Color? GetAlpha(Color lightColor)
        {
            // Aside from SetDefaults, when making a copy of a vanilla weapon you may have to hunt down other bits of code. This code makes the item draw in full brightness when dropped.
            return Color.White;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.TheHorsemansBlade, 1)
                .Register();
        }
    }
}