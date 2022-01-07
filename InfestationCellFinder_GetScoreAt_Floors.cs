using HarmonyLib;
using RimWorld;
using Verse;

namespace ReinforcedFloors
{
    [HarmonyPatch(typeof(InfestationCellFinder))]
    [HarmonyPatch("GetScoreAt")]
    public class InfestationCellFinder_GetScoreAt_Floors
    {
        private static void Postfix(IntVec3 cell, Map map, ref float __result)
        {
            bool res = __result > 0f;            
            if (res)
            {
                bool posCheck = map.terrainGrid.TerrainAt(cell).HasTag("ReinforcedFlooring");
                if (posCheck)
                {
                    __result = 0f;
                }
            }
        }
    }
}
