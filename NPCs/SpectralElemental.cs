using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PS3Mod.Content.NPCs
{
	public class SpectralElemental : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[Type] = 14;

			NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers()
			{
				Velocity = 1f
			};
			NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
		}

		public override void SetDefaults()
		{
			NPC.CloneDefaults(NPCID.ChaosElemental);
			NPC.damage = 40;
			NPC.defense = 30;
			NPC.lifeMax = 400;
			NPC.value = 600f; // 6 silver

			AIType = NPCID.ChaosElemental;
			BannerItem = ModContent.ItemType<Items.Placeable.Banners.SpectralElementalBanner>();
		}

		public override void AI()
		{
			if (NPC.Center.X < Main.player[NPC.target].Center.X)
			{
				NPC.spriteDirection = 1; 
			}
			else
			{
				NPC.spriteDirection = -1; 
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			Player player = spawnInfo.Player;
			if (Main.hardMode && player.ZoneHallow && player.ZoneRockLayerHeight)
			{
				return 0.05f; 
			}
			return 0f;
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
			{
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheHallow,
				new FlavorTextBestiaryInfoElement("Mods.PS3Mod.Bestiary.SpectralElemental"),
			});
		}

		public override Color? GetAlpha(Color drawColor)
		{
			return Color.White * NPC.Opacity;
		}

		public override void FindFrame(int frameHeight)
		{
			if (NPC.velocity.Length() < 0.1f)
			{
				NPC.frameCounter = 0;
				NPC.frame.Y = 0;
				return;
			}

			NPC.frameCounter++;

			if (NPC.frameCounter >= 4.0)
			{
				NPC.frameCounter = 0;
				NPC.frame.Y += frameHeight;

				if (NPC.frame.Y >= frameHeight * Main.npcFrameCount[Type])
					NPC.frame.Y = 0;
			}
		}

	}
}
