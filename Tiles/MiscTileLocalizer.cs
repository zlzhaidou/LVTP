using Stellamod.Tiles;
using Stellamod.Tiles.Abyss.Aurelus;
using Stellamod.Tiles.Catacombs;
using Stellamod.Tiles.Ishtar;
using Stellamod.Tiles.ShrineBreakers.Govheil;
using Stellamod.Tiles.ShrineBreakers.Underground;
using Stellamod.Tiles.Structures.AlcadizNGovheil;
using Stellamod.Tiles.Structures.UnderworldRuins;

namespace LVTC.Tiles;

public class MiscTileLocalizer : ModSystem
{
    public override void Load()
    {
        #region AurelusSummon
        ForceLocalizeSystem.LocalizeByTypeName("AurelusSummon", "RightClick", new() {
            { "Singularity has awoken!", "奇點已蘇醒！" },
            { "What are you doing?? Trying to summon another?", "你要幹什麽？還要再召喚一個嗎？" },
            { "Come at with the key of void and moon, Verlia's Singularity awaits.", "唯有持有虛無與皎月之鑰者，方可與薇莉婭共舞" },
        });
        #endregion
        #region CinderChest
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Tiles.CinderChest", "UnlockChest", new() {
            { "Heavy chest opened!", "開啟了重型寶箱！" },
        });
        #endregion
        #region FlowerSummon
        ForceLocalizeSystem.LocalizeByType(typeof(FlowerSummon), nameof(FlowerSummon.MouseOver), new() {
            { "Old Guard's Shrine", "老守衛的石壇" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(FlowerSummon), nameof(FlowerSummon.RightClick), new() {
            { "The Stone Guardian has awoken!", "石心聖衛已蘇醒！" },
            { "...", "..." },
        });
        #endregion
        #region Gothiv
        ForceLocalizeSystem.LocalizeByType(typeof(Gothiv), nameof(Gothiv.RightClick), new() {
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Gothiv), nameof(Gothiv.MouseOver), new() {
            { "Gothivia's sleeping hut", "歌瑟梵的小棚屋" },
        });
        #endregion
        #region JackPost
        ForceLocalizeSystem.LocalizeByType(typeof(JackPost), nameof(JackPost.RightClick), new() {
            { "Jack has awoken!", "燈籠傑克已蘇醒！" },
            { "...", "..." },
            { "Only a wandering essence can allude my precense, only for you Gothivia! :)", "帶上漂浪焰華來，全部獻給歌瑟梵——" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(JackPost), nameof(JackPost.MouseOver), new() {
            { "Jack's Shrine", "燈籠傑克" },
        });
        #endregion
        #region RestingGrounds
        ForceLocalizeSystem.LocalizeByType(typeof(RestingGrounds), nameof(RestingGrounds.RightClick), new() {
            { "Forgotten Puppet Daedus has Awoken!", "遺世石偶，代達斯已蘇醒!" },
            { "...", "..." },
            { "I cannot raise my axe to one of such dedication to our goddess Gothivia, thank you for your efforts..", "面對為歌瑟梵如此付出之人，我無從下手...感謝您的努力." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(RestingGrounds), nameof(RestingGrounds.MouseOver), new() {
            { "Disturb Ruined Tablet?", "擾動遺跡石碑？" },
        });
        #endregion
        #region CathedralChest
        ForceLocalizeSystem.LocalizeByTypeName("CathedralChest", "UnlockChest", new() {
            { "The chest cannot be open at day due to the Empress of the Moon, Verlia, a special seal is over it. Try again at night.", "薇莉婭的魔力在白天將箱子牢牢鎖住.等夜晚再來試試." },
        });
        #endregion
        #region VerliasShrine
        ForceLocalizeSystem.LocalizeByTypeName("VerliasShrine", "RightClick", new() {
            { "Verlia has been freed from her lantern!", "薇莉婭之魂掙脫了提燈的束縛！" },
            { "See me in the moonlight!", "月下最宜見面！" },
            { "Come at night with our kindred in hand, see you soon for our dance will commend :)", "三更來見燈在手，舞醉月下不知愁" },
        });
        ForceLocalizeSystem.LocalizeByTypeName("VerliasShrine", "MouseOver", new() {
            { "Verlia's Shrine", "薇莉婭聖壇" },
        });
        #endregion
        #region MorrowChest
        ForceLocalizeSystem.LocalizeByTypeName("MorrowChest", "UnlockChest", new() {
            { "The chest cannot be open in the light of the day due to a lock, apparently these feral creatures use their weapons at night. Try again at night.", "箱子被上鎖了.看來那些野生的家夥們只有晚上才會使用裏面的東西.晚上再來試試." },
        });
        ForceLocalizeSystem.LocalizeByTypeName("MorrowChest", "RightClick", new() {
            { "The chest cannot be open in the light of the day due to a lock, apparently these feral creatures use their weapons at night. Try again at night.", "箱子被上鎖了.看來那些野生的家夥們只有晚上才會使用裏面的東西.晚上再來試試." },
        });
        #endregion
        #region UnstableRift
        ForceLocalizeSystem.LocalizeByType(typeof(UnstableRift), nameof(UnstableRift.RightClick), new() {
            { "A disturbing entity prevents the rift from opening...", "一個可怖的存在抑製著裂隙..." },
            { "Sylia rips through!", "賽莉亞破影而出！" },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(UnstableRift), nameof(UnstableRift.MouseOver), new() {
            { "Disturb the Unstable Rift...?", "試探不穩定裂隙...？" },
        });
        #endregion
        #region SunAlter
        ForceLocalizeSystem.LocalizeByTypeName("SunAlter", "RightClick", new() {
            { "Come back with a Sun Stone to fight the warrior of the desert.", "帶上耀日寶石來挑戰沙漠中的戰士." },
            { "Sun Stalker has awoken!", "獵日遊隼已蘇醒！" },
            { "...", "..." },
        });
        #endregion
        #region IlluriaChest
        ForceLocalizeSystem.LocalizeByTypeName("IlluriaChest", "RightClick", new() {
            { "Locked by an Overgrown plant...", "一種奇特的植物長滿其上，將它牢牢封死." },
        });
        #endregion
        #region IshtarChest
        ForceLocalizeSystem.LocalizeByTypeName("IshtarChest", "RightClick", new() {
            { "Zui's access needed.", "讓蕊幫你打開這個！" },
        });
        #endregion

        #region AurelusDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(AurelusDoorClosed), "get_FailString", new() {
            { "You're not ready yet! Key needed!", "你還需要一把鑰匙！" },
        });
        #endregion
        #region CatacombsDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(CatacombsDoorClosed), "get_FailString", new() {
            { "Kill wall of flesh! Key needed!", "先擊殺血肉之墻並拿到鑰匙！" },
        });
        #endregion
        #region IshtarDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(IshtarDoorClosed), "get_FailString", new() {
            { "The door requires an Ishtar Key.", "需要狂淵鑰匙" },
        });
        #endregion
        #region GothivDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(GothivDoorClosed), "get_FailString", new() {
            { "Hun, you cant open this door yet :(", "嗯...你還開不了這扇門" },
        });
        #endregion

        #region 一些 MouseOver
        Dictionary<string, string> breakMeLocalization = new(){
            { "Break Me!", "打破我！" },
        };
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineAlcaPowderC), nameof(ShrineAlcaPowderC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineBUAN), nameof(ShrineBUAN.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineGardenWreckerC), nameof(ShrineGardenWreckerC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineHalhurishC), nameof(ShrineHalhurishC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineLifeC), nameof(ShrineSolMothC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineLights), nameof(ShrineLights.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineSolMothC), nameof(ShrineSolMothC.MouseOver), breakMeLocalization);

        ForceLocalizeSystem.LocalizeByType(typeof(ShrineBridgetC), nameof(ShrineBridgetC.MouseOver), new() {
            { "Hey hey over here break me please :(", "嘿！嘿！那邊的！過來救我出去！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(LabCrystal), nameof(LabCrystal.MouseOver), new() {
            { "Insert a Focal Crystal", "插入聚焦水晶" },
        });
        #endregion
    }
}
