using LunarVeilChinesePackPublicizerPart;
using Microsoft.Xna.Framework;
using Stellamod;
using Stellamod.DropRules;
using Stellamod.Effects;
using Stellamod.Effects.Primitives;
using Stellamod.Helpers;
using Stellamod.Trails;
using Stellamod.UI.Scripture;
using Stellamod.WorldG;
using System.Reflection;
using Terraria.Localization;

namespace LVTC.Miscs;

public class MiscLocalizer : ModSystem
{
    public override void Load()
    {
        #region 事件相關的消息 (EventWorld)
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "GintzeWin", new() {
            { "The Gintze army has been defeated!", "玄鐵軍團已被擊敗！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "TrySpawnGintzeArmy", new() {
            { "The Gintze army is approaching...", "玄鐵軍團正在逼近..." },
            { "The Gintze army is returning for another round...", "玄鐵軍團準備再戰一場..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "TrySpawnAuroreanStarfall", new() {
            { "Aurorean Stars are falling!", "極光之星從天而降！" },
            { "The Aurorean starfall has ended", "極光星雨結束了" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "PostUpdateWorld", new() {
            { "Gothivia has made a return, the skies enlighten and the sun burns bright.", "琉陽當空，霞彩遮天，歌瑟梵已然歸來." },
            { "The Aurorean starfall has ended", "極光星雨結束了" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(StellaMultiplayer), "HandlePacket", new() {
            { "The Aurorean Starfall has been blocked! :(", "極光星雨被阻隔於世界之外:(" },
        });
        #endregion
        #region 條件
        // 主要用於商店註冊, 如果同時啟用 Shop Expand 能在查詢商店時看到漢化效果

        // 挪到了 Mods.Stellamod.Conditions.hjson 中
        /*
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.CustomConditions", ".cctor", new() {
            { "Defeated Fenix", "擊敗緋琦" },
            { "Killed Singularity Fragment", "擊敗破碎奇點" },
            { "Defeated Daedus", "擊敗代達斯" },
            { "Sewing Kit must be Equipped", "必須裝備著織影套件包" },
        });
        */
        CustomConditionsHelper.Localize();
        #endregion
        #region 掉落條件
        ForceLocalizeSystem.LocalizeByType(typeof(BloodmoonDropRule), nameof(BloodmoonDropRule.GetConditionDescription), new() {
            { "During a Bloodmoon", "在血月時" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(HardmodeDropRule), nameof(HardmodeDropRule.GetConditionDescription), new() {
            { "During Hardmode", "在困難模式中" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(PlanteraDropRule), nameof(PlanteraDropRule.GetConditionDescription), new() {
            { "After skeletron is defeated", "在骷髏王被擊敗後" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(SkeletronDropRule), nameof(SkeletronDropRule.GetConditionDescription), new() {
            { "After skeletron is defeated", "在骷髏王被擊敗後" },
        });
        #endregion
        #region 報錯信息
        // 配置是否漢化報錯信息?
        if (AlwaysFalse())
        {
            // 可以無需漢化
            ForceLocalizeSystem.LocalizeInOrderByType(typeof(Primitive3DStrip), ".ctor", new() {
                { "In order to create a primitive 3D strip, a non-null ", "In order to create a primitive 3D strip, a non-null " },
                { "height", "height" },
                { "color", "color" },
                { " function must be specified.", " function must be specified." },
            });
            ForceLocalizeSystem.LocalizeInOrderByType(typeof(PrimitiveTrailCopy), ".ctor", new() {
                { "In order to create a primitive trail, a non-null ", "In order to create a primitive trail, a non-null " },
                { "height", "height" },
                { "color", "color" },
                { " function must be specified.", " function must be specified." },
            });
            ForceLocalizeSystem.LocalizeInOrderByType(typeof(PrimitiveTrail), ".ctor", new() {
                { "In order to create a primitive trail, a non-null ", "In order to create a primitive trail, a non-null " },
                { "height", "height" },
                { "color", "color" },
                { " function must be specified.", " function must be specified." },
            });
            ForceLocalizeSystem.Localize(typeof(EaseBuilder).GetMethod(nameof(EaseBuilder.AddPoint), [typeof(Vector2), typeof(EaseFunction)]), new() {
                { "X value of point is not in valid range!", "X value of point is not in valid range!" },
                { "New point has an x value less than the previous point when it should be greater or equal", "New point has an x value less than the previous point when it should be greater or equal" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "ReadModWall", new() {
                { "Mod was not loaded for walltype, returning 0", "Mod was not loaded for walltype, returning 0" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "ReadModTile", new() {
                { "Mod was not loaded, placing dirt instead", "Mod was not loaded, placing dirt instead" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteModdedWall", new() {
                { "Write modded wall was called with a vanilla wall type", "Write modded wall was called with a vanilla wall type" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteVanillaWall", new() {
                { "Write vanilla wall was called with a modded wall type, type = ", "Write vanilla wall was called with a modded wall type, type = " },
                { " and wallid count = ", " and wallid count = " },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteVanillaTile", new() {
                { "modded tile was used in WriteVanillaTile", "modded tile was used in WriteVanillaTile" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteModdedTile", new() {
                { "Write modded tile was called with a vanilla tile type", "Write modded tile was called with a vanilla tile type" },
            });
        }
        #endregion
        #region UI
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.UI.Dialogue.DialoguePanel", "OnInitialize", new() {
            { "Hi There :D", "你好啊 :D" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(ScripturePanel), "OnInitialize", new() {
            { "Hello world!", "Hello world!" },
        });
        #endregion
        #region 世界生成
        Dictionary<string, string> worldGenLocalizations = new(){
            { "The Veiled people planting trees!", "正在觀察天紗臣民種樹" },
            { "Golden Ambience ruining the world", "正在準備BGM" },
            { "Buring the landscape with Cinder and Fable", "正在用古諭之火灼燒大地" },
            { "Ereshkigal secretly hiding Sigfried", "厄莉什基迦勒正在藏起齊格飛" },
            { "Creating life near spawn :)", "正在為出生點附近帶去生機" },
            { "Witches spreading love all inside you!", "正在感受女巫們的愛意" },
            { "You aren't escaping the Kill Pillars", "你可逃不脫打四柱的命運" },
            { "Adding life to the world!", "正在為世界增加更多生靈" },
            { "Building Gintze houses", "正在為玄鐵軍團蓋房子" },
            { "Bird building alters", "正在看鳥築巢" },
            { "Gia living fruitfully", "正在觀察吉婭做實驗" },
            { "Definitely not making elder guardians from minecraft.", "絕對不是正在將我的世界中的遠古守衛者偷過來" },
            { "Definitely not making even more trapped elder guardians", "絕對不是正在將我的世界中的更多遠古守衛者偷過來" },
            { "Definitely not making some trapped elder guardians", "絕對不是正在將我的世界中的遠古守衛者和陷阱偷過來" },
            { "The Almighty weapon being burried", "正在埋藏遠古神兵" },
            { "Burning the world with catacombs", "正在建造烈火墓穴" },
            { "Trapping the world with catacombs", "正在建造陷阱墓穴" },
            { "Rallad killing people", "正在往死裏嗨" },
            { "Finding a place for the shop", "正在找地方建造商店" },
            { "Singularities singing!", "正在聽奇點歌唱" },
            { "Irradia marrying Paraffin instead of Delgrim", "正在勸說伊瑞蒂安和帕拉芬結婚，而不是戴爾格林" },
            { "Shifting Shadows deep in the Ice", "正在冰雪的深處挪動陰影" },
            { "Virulifying the Morrow", "正在散播瘴煞" },
            { "Residents of the veil believing in a god", "正在觀察天紗臣民祭拜神明" },
            { "Residents of the veil crafting chasms", "正在觀察天紗臣民製作物品" },
            { "Fighting the Virulent with magic", "正在用魔法對抗瘴煞" },
            { "Niivi protecting the cities above.", "正在觀察尼伊維保衛城市" },
            { "Leaving the Royal Capital", "正在撤出皇都" },
            { "Scorching Gild and Arnchar burning into the world", "正在加入赤鐵和熾金" },
            { "Scorching Arnchar into the world", "正在加入赤鐵" },
            { "Scorching more Arnchar into the world", "正在加入更多赤鐵" },
            { "Freezing the world with Frile", "正在凍結月冰" },
            { "Blackening Stones for racist effect", "正在把墻壁塗黑" },
            { "Veribloom forgetting their memories", "正在讓薇綠失憶" },
            { "Getting shafted", "正在被詐騙" },
            { "Sylia using magic in the Underworld", "正在觀察賽利亞在地獄作法" },
            { "Hunters getting kicked out", "正在驅逐獵人" },
            { "Hunters settling down", "正在引導獵人定居" },
            { "Praising our lord and savior Niivi", "正在歌頌我們偉大的尼伊維" },
            { "Verlia Ark", "正在發電" },
            { "Veldris Building his house", "正在觀察維爾德斯造房子" },
            { "Sigfried being demoralized", "正在讓齊格飛破防" },
            { "Azurerin Sleeping the whole time", "正在偷窺艾祖瑞霖睡覺" },
            { "Cozmire getting her singularity stolen", "正在偷取天寰神巫的奇點" },
            { "Lumi collecting singularities", "正在觀察琉明收集奇點" },
            { "Gothivia preparing her escape.", "正在祝歌瑟梵逃脫順利" },
            { "Dreading..", "正在害怕" },
            { "Gild settling in the ground", "正在穩定地層中的金光" },
        };
        if (AlwaysFalse())
        {
            // 這一塊不用漢化
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenFabledTrees", new() {
                { "The Veiled people planting trees!", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAmbience", new() {
                { "Golden Ambience ruining the world", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenFabiliaRuin", new() {
                { "Buring the landscape with Cinder and Fable", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenManor", new() {
                { "Ereshkigal secretly hiding Sigfried", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenStoneCastle", new() {
                { "Creating life near spawn :)", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenXixVillage", new() {
                { "Witches spreading love all inside you!", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenGraving", new() {
                { "You aren't escaping the Kill Pillars", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenWindmills", new() {
                { "Adding life to the world!", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenMed", new() {
                { "Building Gintze houses", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenBig", new() {
                { "Building Gintze houses", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenStalker", new() {
                { "Bird building alters", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenGiaHouse", new() {
                { "Gia living fruitfully", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenSeaTemple", new() {
                { "Definitely not making elder guardians from minecraft.", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsWater2", new() {
                { "Definitely not making even more trapped elder guardians", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsWater", new() {
                { "Definitely not making some trapped elder guardians", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenBridget", new() {
                { "The Almighty weapon being burried", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsFlames", new() {
                { "Burning the world with catacombs", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsTrap", new() {
                { "Trapping the world with catacombs", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenRallad", new() {
                { "Rallad killing people", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenMechShop", new() {
                { "Finding a place for the shop", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAurelusTemple", new() {
                { "Singularities singing!", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenGovheilCastle", new() {
                { "Irradia marrying Paraffin instead of Delgrim", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAbysm", new() {
                { "Shifting Shadows deep in the Ice", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCinderspark", new() {
                { "Shifting Shadows deep in the Ice", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenVirulent", new() {
                { "Virulifying the Morrow", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenVeilSpot", new() {
                { "Residents of the veil believing in a god", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenVU", new() {
                { "Residents of the veil crafting chasms", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAlcadSpot", new() {
                { "Fighting the Virulent with magic", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenRoyalCapital", new() {
                { "Fighting the Virulent with magic", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenIlluria", new() {
                { "Niivi protecting the cities above.", "不用輸入漢化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenSylia", new() {
                { "Leaving the Royal Capital", "不用輸入漢化文本" },
            });
            // ...
            // 寫累了, 不想寫了, 幹脆直接給全部方法上上好了
        }
        foreach (var method in typeof(StellaWorld).GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
        {
            if (method.DeclaringType != typeof(StellaWorld))
            {
                continue;
            }
            ForceLocalizeSystem.Localize(method, worldGenLocalizations);
        }
        #endregion
        #region 菜單界面名
        MonoModHooks.Add(typeof(Stellamenu).GetMethod("get_DisplayName"), (Func<Stellamenu, string> orig, Stellamenu self) => {
            return Language.GetTextValue("Mods.Stellamod.Menus.Stellamenu.DisplayName");
        });
        #endregion
    }
    private static bool AlwaysFalse() => false;
}
