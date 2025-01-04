using GameNetcodeStuff;
using HarmonyLib;

namespace DrakesCompany.Patches {
    
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void InfiniteSprintPatch(ref float __sprintMeter) {
            __sprintMeter = 1.0F;
        }
        
    }
}