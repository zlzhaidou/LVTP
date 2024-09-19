using MonoMod.Cil;
using MonoMod.Utils;
using System.Reflection;
using Terraria.ModLoader.Config;

namespace LVTC.Configs;

public class ConfigLocalizer : ModSystem
{
    private const BindingFlags BFALL = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
    private const string LocalizedMod = "Stellamod";
    public override void Load()
    {
        #region Header
        // 它 Header 都硬編碼, 呃呃呃呃呃呃啊啊啊
        var uiModConfigType = typeof(Main).Assembly.GetType("Terraria.ModLoader.Config.UI.UIModConfig", true) ?? throw new Exception("Can't find UIModConfig");
        var uiModConfigModField = uiModConfigType.GetField("mod", BFALL) ?? throw new Exception("Can't find UIModConfig.mod");
        var uiModConfigModConfigField = uiModConfigType.GetField("modConfig", BFALL) ?? throw new Exception("Can't find UIModConfig.modConfig");
        var headAttributeKeyFaskInvoker = (typeof(HeaderAttribute).GetField("key", BFALL) ?? throw new Exception("Can't find HeaderAttribute.key")).GetFastInvoker();
        var headAttributeIdentifierFaskInvoker = (typeof(HeaderAttribute).GetField("identifier", BFALL) ?? throw new Exception("Can't find HeaderAttribute.identifier")).GetFastInvoker();
        MonoModHooks.Modify(uiModConfigType.GetMethod("HandleHeader", BFALL), il => {
            ILCursor cursor = new(il);
            if (!cursor.TryGotoNext(MoveType.After, i => i.MatchStloc0()))
            {
                Mod.Logger.Error("IL UIModConfig.Handle Header error: can't find stloc.0");
                return;
            }
            cursor.EmitLdarg0();
            cursor.EmitLdfld(uiModConfigModField);
            cursor.EmitLdarg0();
            cursor.EmitLdfld(uiModConfigModConfigField);
            cursor.EmitLdloc0();
            cursor.EmitDelegate((Mod? mod, ModConfig? config, HeaderAttribute? header) => {
                if (header == null || config == null || mod == null || mod.Name != LocalizedMod)
                {
                    return;
                }
                if (header.IsIdentifier)
                {
                    var key = (string)headAttributeKeyFaskInvoker.Invoke(header, [])!;
                    headAttributeKeyFaskInvoker.Invoke(header, [$"Mods.{LocalizedMod}.Configs.{config.Name}.Headers.{key}"]);
                    headAttributeIdentifierFaskInvoker.Invoke(header, [null]);
                }
            });
        });
        #endregion
    }
}
