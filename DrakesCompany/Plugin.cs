using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;

namespace DrakesCompany {
    
    [BepInPlugin(ModID, ModName, ModVersion)]
    [BepInDependency(LethalLib.Plugin.ModGUID)]
    public class DrakesCompany : BaseUnityPlugin {
        
        private const string ModID = "com.github.Nyxify.DrakesCompany";
        private const string ModName = "DrakesCompany";
        private const string ModVersion = "1.0.0";
        
        private readonly Harmony _harmony = new Harmony(ModID);
        private static DrakesCompany _instance;
        private ManualLogSource _logger;
        
        void Awake() {
            if (_instance == null) {
                _instance = this;
            }
            
            _logger = BepInEx.Logging.Logger.CreateLogSource(ModName);
            _harmony.PatchAll(typeof(DrakesCompany));
            _harmony.PatchAll(typeof(PlayerControllerB));
            _logger.Log(LogLevel.Info, "DrakesCompany has diddled you!");
        }
        
    }
    
}
