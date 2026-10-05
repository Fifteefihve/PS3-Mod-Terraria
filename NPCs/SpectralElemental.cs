using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs
{
	// Old-gen console / 3DS Spectral Elemental: a stronger, rarer Underground Hallow variant of the Chaos Elemental.
	// Expects SpectralElemental.png using the same frame layout as the vanilla Chaos Elemental sprite sheet.
	public class SpectralElemental : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.ChaosElemental];

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

			AIType = NPCID.ChaosElemental;        // Fighter AI with the Chaos Elemental's teleporting
			AnimationType = NPCID.ChaosElemental;

			// TODO: Spectral Elemental Banner (needs a banner item + tile of your own).
		}

		// The console wiki lists coins only (no item drops) for the Spectral Elemental,
		// so there is no ModifyNPCLoot here.

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			Player player = spawnInfo.Player;
			if (Main.hardMode && player.ZoneHallow && player.ZoneRockLayerHeight)
			{
				return 0.05f; // Rarer than the Chaos Elemental. Spawn weight is a guess.
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
	}
}
