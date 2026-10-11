using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs
{
	public class DragonSkull : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[Type] = 3;

			NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers()
			{
				Velocity = 1f
			};
			NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
		}

		public override void SetDefaults()
		{
			NPC.CloneDefaults(NPCID.CursedSkull);
			NPC.damage = 20;
			NPC.defense = 8;
			NPC.lifeMax = 75;
			NPC.value = 10000f; 

			AIType = NPCID.CursedSkull;        
			AnimationType = NPCID.CursedSkull; 

			BannerItem = ModContent.ItemType<Items.Placeable.Banners.DragonSkullBanner>();
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot)
		{
			IItemDropRule goldenKey = ItemDropRule.Common(ItemID.GoldenKey, 67);
			goldenKey.OnFailedRoll(ItemDropRule.Common(ItemID.Bone, 1, 1, 3));
			npcLoot.Add(goldenKey);

			npcLoot.Add(ItemDropRule.Common(ItemID.Nazar, 100)); // 1%
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.Player.ZoneDungeon)
			{
				return 0.25f; 
			}
			return 0f;
		}

		public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
		{
			if (Main.rand.NextBool(3))
			{
				target.AddBuff(BuffID.Cursed, 4 * 60);
			}
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
			{
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheDungeon,
			});
		}
	}
}