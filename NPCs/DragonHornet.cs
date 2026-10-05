using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs
{
	// Old-gen console / 3DS Dragon Hornet: a stronger Underground Jungle variant of the Hornet.
	// Expects DragonHornet.png using the same frame layout as the vanilla Hornet sprite sheet.
	public class DragonHornet : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.Hornet];

			NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers()
			{
				Velocity = 1f
			};
			NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
		}

		public override void SetDefaults()
		{
			NPC.CloneDefaults(NPCID.Hornet);
			NPC.damage = 20;
			NPC.defense = 20;
			NPC.lifeMax = 75;
			NPC.value = 4000f; // The wiki lists "40"; I read that as 40 silver. Adjust if it should be copper.

			AIType = NPCID.Hornet;        // Flying AI (it also fires stingers like the Hornet)
			AnimationType = NPCID.Hornet;

			// TODO: no banner is listed for the Dragon Hornet on the console wiki.
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot)
		{
			npcLoot.Add(ItemDropRule.Common(ItemID.Stinger, 2, 1, 3)); // 50%, 1-3
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			Player player = spawnInfo.Player;
			if (player.ZoneJungle && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight))
			{
				return 0.1f; // Spawn weight is a guess.
			}
			return 0f;
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
			{
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Jungle,
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Underground,
				new FlavorTextBestiaryInfoElement("Mods.PS3Mod.Bestiary.DragonHornet"),
			});
		}
	}
}
