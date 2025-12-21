using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using HarmonyLib;
using events = Exiled.Events.Handlers;
using lab = LabApi.Events.Handlers;

namespace AdvancedScp914
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "AdvancedScp914";
        public override string Prefix => Name;
        public override string Author => "Morkamo";
        public override Version RequiredExiledVersion => new(9, 1, 0);
        public override Version Version => new(1, 1, 0);

        public static Plugin Instance;
        public static Harmony Harmony;
        public UpgradeHandler UpgradeHandler;
        
        private void RegisterEvents()
        {
            lab.Scp914Events.ProcessedPlayer += UpgradeHandler.OnPlayerProcessedInScp914;
        }

        private void UnregisterEvents()
        {
            lab.Scp914Events.ProcessedPlayer -= UpgradeHandler.OnPlayerProcessedInScp914;
        }
        
        public override void OnEnabled()
        {
            Instance = this;
            
            Harmony = new Harmony("ru.morkamo.advancedScp914.patches");
            Harmony.PatchAll();

            UpgradeHandler = Config.UpgradeHandler;
            
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            
            Harmony.UnpatchAll();

            UpgradeHandler = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}