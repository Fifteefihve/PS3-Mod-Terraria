using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs
{
	public class ArchDemon : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[Type] = 4;

			NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers()
			{
				Velocity = 1f
			};
			NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
		}

		public override void SetDefaults()
		{
			NPC.CloneDefaults(NPCID.Demon); 
			NPC.damage = 41;
			NPC.defense = 8;
			NPC.lifeMax = 500;
			NPC.value = 6800f; 
			AIType = NPCID.Demon;        
			BannerItem = ModContent.ItemType<Items.Placeable.Banners.ArchDemonBanner>();
		}
//7
		public override void AI()
		{
			if (NPC.Center.X < Main.player[NPC.target].Center.X)
			{
				NPC.spriteDirection = -1; 
			}
			else
			{
				NPC.spriteDirection = 1; 
			}
		}

		public override void FindFrame(int frameHeight)
		{
			NPC.frameCounter++;
			if (NPC.frameCounter >= 7) 
			{
				NPC.frameCounter = 0;
				NPC.frame.Y += frameHeight;

				if (NPC.frame.Y >= frameHeight * 4)
				{
					NPC.frame.Y = 0;
				}
			}
		}
		public override void ModifyNPCLoot(NPCLoot npcLoot)
		{
			npcLoot.Add(ItemDropRule.Common(ItemID.DemonScythe, 50));       
			npcLoot.Add(ItemDropRule.Common(ItemID.CrystalShard, 1, 4, 9)); 
			npcLoot.Add(ItemDropRule.Common(ItemID.CrystalStorm, 500));     
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.Player.ZoneUnderworldHeight)
			{
				return 0.15f;
			}
			return 0f;
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
			{
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheUnderworld,
			});
		}
	}
}