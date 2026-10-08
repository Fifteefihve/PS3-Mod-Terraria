using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.NPCs.Bosses.Ocram   // match your namespace
{
    public class OcramServantSwap : GlobalNPC
    {
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            if (npc.type == NPCID.ServantofCthulhu
                && source is EntitySource_Parent parent
                && parent.Entity is NPC owner
                && owner.type == ModContent.NPCType<Ocram>())
            {
                npc.Transform(ModContent.NPCType<ServantofOcram>());
            }
        }
    }
}