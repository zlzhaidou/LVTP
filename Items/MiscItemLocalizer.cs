using Stellamod.Items.Consumables;

namespace LVTC.Items;

public class MiscItemLocalizer : ModSystem
{
    public override void Load()
    {
        #region EDR
        ForceLocalizeSystem.LocalizeByType(typeof(EDR), nameof(EDR.UseItem), new() {
            { "A disruption has occured!", "出現了異常擾動！" },
            { "Initiate death protocol", "啟動死亡協議..." },
            { "The end is nigh…", "末日將臨..." },
            { "Tactical nuke incoming…", "戰術核彈已部署..." },
            { "We』re here to contact you about your deaths extended warranty", "我們想要通知您，您的死亡保證書已延期" },
            { "Brace for impact…", "沖擊警告..." },
            { "Not Contaminated life form detacted!", "偵測到未被汙染的生命體！" },
            { "Prepare for voltile Termenation!", "準備迎接大範圍毀滅打擊！" },
            { "You』re going to have a bad time…", "你可要經歷一段壞時光了..." },
            { "Usage outside of contamination detacted!", "警告：偵測到在輻射之外使用" },
        });
        #endregion
        #region LittleWand
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Accessories.AlcadChests.LittleWand", "Bad", new() {
            { "Aurorean Stars are... wait, what?", "極光之星從...等會，咋回事？" },
        });
        #endregion
        #region TomeofRaining
        ForceLocalizeSystem.LocalizeByTypeName("TomeofRaining", "UseItem", new() {
            { "Zui decided to help you make it rain!", "蕊給你弄來了幾片雨雲！" },
        });
        #endregion
        #region DreadMedalion
        ForceLocalizeSystem.LocalizeByTypeName("DreadMedalion", "UseItem", new() {
            { "The air fills with dread...", "恐懼的氣息彌散四周..." },
        });
        #endregion
        #region RadianceStone
        ForceLocalizeSystem.LocalizeByTypeName("RadianceStone", "UseItem", new() {
            { "Zui has come to have some fun!", "我來炫翻全場！" },
            { "Lets get started!", "開始吧！" },
            { "Lets have some fun shall we?", "戰鬥，好玩！" },
            { "Zui is coming to party!", "我來大鬧一場！" },
            { "You wanna fight today??", "想要幹一場？隨時奉陪！" },
            { "Here I come :)", "泰拉人，要上了！" },
            { "I don't wanna fight right now :(", "好累累，不想打架...:(" },
            { "Prepare to get rekted", "準備好大敗而歸吧！" },
            { "You're gonna have a good time", "這一定會是一段超棒的時光！" },
            { "Womp womp you used the item :)", "哦哦！你終於用它了！" },
        });
        #endregion
        #region STARBLOCKER
        ForceLocalizeSystem.LocalizeByTypeName("STARBLOCKER", "UseItem", new() {
            { "The Aurorean Starfall has been blocked! :(", "極光星雨被阻隔於世界之外:(" },
        });
        #endregion
    }
}
