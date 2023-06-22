using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;

using UnityEngine;

namespace Gaylatea
{
    namespace DisableSpatialAudio
    {
        [BepInPlugin("com.gaylatea.disablespatialaudio", "SPT-DisableSpatialAudio", "1.0.0")]
        public class Plugin : BaseUnityPlugin
        {
            internal static ManualLogSource logger;

            public Plugin()
            {
                logger = Logger;

                new DisableSpatialAudioPatch().Enable();

                Logger.LogInfo($"[DisableSpatialAudio] Loaded.");
            }
        }
    }
}