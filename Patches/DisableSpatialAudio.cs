
using System.Reflection;

using Aki.Reflection.Patching;

using HarmonyLib;

namespace Gaylatea
{
    namespace DisableSpatialAudio
    {
        /// <summary>
        /// Turns off BSG's custom occlusion math.
        /// </summary>
        class DisableSpatialAudioPatch : ModulePatch
        {
            protected override MethodBase GetTargetMethod()
            {
                return AccessTools.TypeByName("SpatialAudioSystem").GetMethod("Initialize", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            }

            [PatchPostfix]
            public static void PatchPostfix(ref bool ___bool_0)
            {   
                ___bool_0 = false;
            }

        }
    }
}