using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs
{
	// Old-gen console / 3DS Dragon Skull: a bigger Dungeon variant of the Cursed Skull.
	// Expects DragonSkull.png using the same frame layout as the vanilla Cursed Skull sprite sheet.
	public class DragonSkull : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.CursedSkull];

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
			NPC.value = 10000f; // The console wiki lists 1 gold coin. Lower it if that seems too high.

			AIType = NPCID.CursedSkull;        // Cursed Skull AI (circle, then lunge, through walls)
			AnimationType = NPCID.CursedSkull;

			// TODO: no banner is listed for the Dragon Skull on the console wiki.
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot)
		{
			// Golden Key (about 1.5%) and Bone (1-3) are mutually exclusive, Nazar is a separate 1% roll.
			// 1 in 67 is 1.49%, the closest whole-number odds to the 1.5% on the wiki.
			IItemDropRule goldenKey = ItemDropRule.Common(ItemID.GoldenKey, 67);
			goldenKey.OnFailedRoll(ItemDropRule.Common(ItemID.Bone, 1, 1, 3));
			npcLoot.Add(goldenKey);

			npcLoot.Add(ItemDropRule.Common(ItemID.Nazar, 100)); // 1%
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.Player.ZoneDungeon)
			{
				return 0.25f; // Spawn weight is a guess.
			}
			return 0f;
		}

		public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
		{
			// The Dragon Skull has a chance to inflict Cursed for 4 seconds, like the Cursed Skull (33%).
			if (Main.rand.NextBool(3))
			{
				target.AddBuff(BuffID.Cursed, 4 * 60);
			}
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
			{
				// If the compiler says "TheDungeon" doesn't exist in Biomes, just delete this line.
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheDungeon,
				new FlavorTextBestiaryInfoElement("Mods.PS3Mod.Bestiary.DragonSkull"),
			});
		}
	}
}