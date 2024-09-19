using LunarVeilChinesePackPublicizerPart;
using MonoMod.RuntimeDetour;

namespace LVTC.Systems;

#if DEBUG
public class BlockPublishInDebug : ModSystem
{
    Hook? blockHook;
    public override void Load()
    {
        blockHook = BlockPublishHelper.BlockPublish(m => m == nameof(LunarVeilChinesePack), "禁止在 DEBUG 模式下發布此模組!");
    }
}
#endif
