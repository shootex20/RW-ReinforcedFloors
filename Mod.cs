using Verse;
using HarmonyLib;

namespace ReinforcedFloors
{
    [StaticConstructorOnStartup]
    public class Mod : Verse.Mod
    {
        public Mod(ModContentPack content) : base(content)
        {
            Harmony harmony = new Harmony("shootex.rimworld.rf");
            harmony.PatchAll();
        }
    }
}
