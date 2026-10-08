using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs.Bosses.Ocram
{
    public class ServantofOcram : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 2;

            NPCID.Sets.DontDoHardmodeScaling[Type] = true;
            NPCID.Sets.CantTakeLunchMoney[Type] = true;
            NPCID.Sets.BossBestiaryPriority.Add(Type);

            NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers()
            {
                Velocity = 1f
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
        }

        public override void SetDefaults()
        {
            int width = 54;
            int height = width;
            NPC.Size = new Vector2(width, height);

            NPC.aiStyle = NPCAIStyleID.Flying;
            AIType = NPCID.ServantofCthulhu;

            NPC.lifeMax = 130;
            NPC.damage = 35;
            NPC.defense = 5;
            NPC.knockBackResist = 0f;

            NPC.HitSound = SoundID.NPCHit18;
            NPC.DeathSound = SoundID.NPCHit18;
        }

        public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)
        {
            NPC.lifeMax = 650 + (int)(numPlayers > 1 ? NPC.lifeMax * 0.35f * numPlayers : 0);
            NPC.damage = 115;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            int associatedNPCType = ModContent.NPCType<Ocram>();
            bestiaryEntry.UIInfoProvider = new CommonEnemyUICollectionInfoProvider
            (
                ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[associatedNPCType], quickUnlock: true);

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,
                new FlavorTextBestiaryInfoElement("A fragmented servant of the corrupted eye.")
            });
        }

        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;

            if (NPC.frameCounter >= 6)
            {
                NPC.frameCounter = 0;
                NPC.frame.Y += frameHeight;

            if (NPC.frame.Y >= frameHeight * 2)
                NPC.frame.Y = 0;
            }
        }

        /*public override void HitEffect(NPC.HitInfo hit)
        {
            if (Main.netMode == NetmodeID.Server)
                return;

            for (int i = 0; i < 3; i++) //
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hit.HitDirection, -1f, 0, default, 1f);

            
        }*/

        public override void OnKill()
        {
            if (Main.rand.NextBool(2))
                Item.NewItem(NPC.GetSource_Death(), (int)NPC.position.X, (int)NPC.position.Y, NPC.width, NPC.height, ItemID.Heart);
        }

        public override void AI()
        {
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.position += NPC.velocity * 0.5f;
        }
    }
}