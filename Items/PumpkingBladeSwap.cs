using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PS3Mod.Content.Items
{
    public class PumpkingBladeSwap : GlobalItem
    {
        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
            => entity.type == ItemID.TheHorsemansBlade;

        public override void OnSpawn(Item item, IEntitySource source)
        {
            if (source is EntitySource_Loot loot
                && loot.Entity is NPC npc
                && npc.type == NPCID.Pumpking)
            {
                int stack = item.stack;
                item.SetDefaults(ModContent.ItemType<OldHorsemansBlade>());
                item.stack = stack;
            }
        }
    }
}