using BepInEx;
using HarmonyLib;
using BepInEx.Logging;
using BepInEx.Configuration;
using System.Collections.Generic;

namespace BlazeStatTrak
{
  [BepInPlugin("no.gentle.plugin.blazestattrak", "BlazeStatTrak", "1.0.0")]
  [BepInDependency(LLBML.PluginInfos.PLUGIN_ID)]
  [BepInDependency("no.mrgentle.plugins.llb.modmenu", BepInDependency.DependencyFlags.SoftDependency)]
  public class BlazeStatTrak : BaseUnityPlugin {
    internal static BlazeStatTrak Instance { get; private set; } = null;
    internal static ManualLogSource Log { get; private set; } = null;
    internal static ConfigFile ConfigInstance { get; private set; } = null;
    public static Harmony harmony = new(PluginInfo.PLUGIN_NAME);
    public static BepInEx.PluginInfo pluginInfo;
    
    private void Awake() {
      Instance = this;
      Log = Logger;
      pluginInfo = Info;
      ConfigInstance = Config;
      
      LLBML.Utils.ModDependenciesUtils.RegisterToModMenu(Info, new List<sotring>{
          "Blaze Stat Trak tracks statistics across matches to be displayed in the post match results screen.","",
      });

      Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }
  }
}