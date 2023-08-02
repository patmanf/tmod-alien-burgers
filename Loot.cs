using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlienBurger;

public class Loot : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        if (npc.type == NPCID.Scutlix)
        {
            npcLoot.Add(ItemDropRule.Food(ModContent.ItemType<AlienBurger>(), 10));
        }
    }
}
