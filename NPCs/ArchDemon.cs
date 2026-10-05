using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs
{
	// Old-gen console / 3DS Arch Demon: a tougher Underworld variant of the Demon.
	// Expects ArchDemon.png using the same frame layout as the vanilla Demon sprite sheet.
	// NOTE: the Demon Sickles it throws come from the vanilla Demon AI, so their damage is whatever the
	// vanilla Demon uses, not the 31 listed on the console wiki. Matching 31 exactly needs custom AI.
	public class ArchDemon : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.Demon];

			NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers()
			{
				Velocity = 1f
			};
			NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
		}

		public override void SetDefaults()
		{
			NPC.CloneDefaults(NPCID.Demon); // Also copies lava immunity.
			NPC.damage = 41;
			NPC.defense = 8;
			NPC.lifeMax = 500;
			NPC.value = 6800f; // 68 silver

			AIType = NPCID.Demon;        // Bat-style flying AI that throws Demon Sickles
			AnimationType = NPCID.Demon;

			// TODO: Arch Demon Banner (needs a banner item + tile of your own).
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot)
		{
			npcLoot.Add(ItemDropRule.Common(ItemID.DemonScythe, 50));       // 2%
			npcLoot.Add(ItemDropRule.Common(ItemID.CrystalShard, 1, 4, 9)); // 100%, 4-9 (even before Hardmode)
			npcLoot.Add(ItemDropRule.Common(ItemID.CrystalStorm, 500));     // 0.2%
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.Player.ZoneUnderworldHeight)
			{
				return 0.15f; // Spawn weight is a guess.
			}
			return 0f;
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
			{
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheUnderworld,
				new FlavorTextBestiaryInfoElement("Mods.PS3Mod.Bestiary.ArchDemon"),
			});
		}
	}
}
