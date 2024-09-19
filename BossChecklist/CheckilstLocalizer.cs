using Stellamod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVTC.BossChecklist
{
    public class CheckilstLocalizer : ModSystem
    {
        public override void Load()
        {
            //[i:別刪 開頭的[ 別刪
            #region DoSunStalkerIntegration(烈日遊隼)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSunStalkerIntegration", new() {
                { "Use a [i:","在沙漠的祭壇上使用[i:" },
                {"] at an altar in the desert.","]以召喚." }
            });
            #endregion

            #region DoJackIntegration(燈籠傑克)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoJackIntegration", new() {
                { "Use a [i:","在夜晚進入古諭遺境並使用[i:" },
                {"] at a post in the Fabled Castle to the right at night.","]以召喚." }
            });
            #endregion

            #region DoDaedusIntegration(世遺者代達斯)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoDaedusIntegration", new() {
                { "Disturb with the ruined tablet deep within the morrow.","擾動幽曦地下深處的遺跡石碑" },
            });
            #endregion

            #region DoDreadmireIntegration(絳淵惡巫)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoDreadmireIntegration", new() {
                { "Destroy 3 dread monoliths to create a Dread medallion and summon her during night.","摧毀三個恐怖巨石來合成恐懼徽章在夜晚召喚." },
            });
            #endregion

            #region DoCommanderGintziaIntegration(金戈亞指揮官)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoCommanderGintziaIntegration", new() {
                { "Randomly each day, if you have 3 npcs and have killed the Stone Guardian, an army will raid you!","當你擊殺了石心聖衛並且擁有至少三個NPC時，一支軍隊將將會入侵！" },
            });
            #endregion

            #region DoNESTIntegration(輻射巢穴)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoNESTIntegration", new() {
                { "Buy a [i:","從吉婭處購買 [i:" },
                {"] from Gia and use it in the virulent acid or find an Unknown Signal.","] 並使用，以在瘴煞地找到位置信號." }
            });
            #endregion

            #region DoSingularityFragmentIntegration(破碎奇點)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSingularityFragmentIntegration", new() {
                { "Use a [i:","在冰雪深處的匿影中使用 [i:" },
                {"] at an altar, in the Aurelus, deep in the ice.","] 以召喚." }
            });
            #endregion

            #region DoVerliaIntegration(皎月薇莉婭)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoVerliaIntegration", new() {
                //Use a [i:{summonItem7}] at a shrine in the Cathedral over the ice biome!
                { "Use a [i:","在雪原的儀殿中，找到聖壇並使用 [i:" },
                {"] at a shrine in the Cathedral over the ice biome!","] 以召喚." }
            });
            #endregion

            #region DoGothiviaIntegration(青黯琉曦 歌瑟梵•伊斯)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoGothiviaIntegration", new() {
                { "After killing her friend Irradia, Green sun will start and she will await your arrival, kill Rek to challenge her.","在你殺死伊瑞蒂安後，歌瑟梵將等待著你. 擊殺萊克後你將獲得挑戰她的資格." },
            });
            #endregion

            #region DoIrradiaIntegration(輻射巢穴)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoIrradiaIntegration", new() {
                { "Give Irradia a [i:","在瘴煞深處的歌維赫堡給予伊瑞蒂安 [i:" },
                {"] at a bottom of the Govheil Castle, underneath the Virulent.","] 以召喚." }
            });
            #endregion

            #region DoSyliaIntegration(賽莉亞)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSyliaIntegration", new() {
                { "Interact with the strange anomaly that lies in within the Underworld Ruins.","與地獄中的不穩定裂隙互動以召喚." },
            });
            #endregion

            #region DoSTARIntegration(星 爆 者)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSTARIntegration", new() {
                {"Randomly during a hardmode Aurorean Starfall, they may fall from the sky.","在困難模式下的極光星雨中有幾率掉下來！" }
            });
            #endregion

            #region DoFenixIntegration(緋琦)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoFenixIntegration", new() {
                {"She resides in the royal capital far to the left, she may want to play with you!","在左面天空的皇都上找到她，她很想和你一起玩！" }
            });
            #endregion

            #region DoZuiIntegration(輝光女神 蕊)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoZuiIntegration", new() {
                {"After Plantera, Zui will sell you an item that'll allow you to fight her in the witch town!","在擊敗世紀之花後，蕊會售賣一個物品以允許你在女巫村莊挑戰她." }
            });
            #endregion

            #region DoStoneGolemIntegration(石心聖衛)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoStoneGolemIntegration", new() {
                {"Interact with the Old Guard's Shrine. After using the rock in your Starter bag.","使用新手禮包中的石頭以傳送到召喚地點，右鍵石心之花以召喚." }
            });
            #endregion

            #region DoBlazingSerpentIntegration(烈焰長蛇)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoBlazingSerpentIntegration", new() {
                {"Use a Cursed Shard at an altar in the Fire Catacombs, it may appear...","在烈火墓穴中的祭壇使用詛咒殘片，它或許會出現..." }
            });
            #endregion

            #region DoCogworkIntegration(廢舊齒輪)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoCogworkIntegration", new() {
                {"Use a Cursed Shard at an altar in the Trapped or Water Catacombs, it may appear...","在浸水墓穴或陷阱墓穴中的祭壇使用詛咒殘片，它或許會出現..." }
            });
            #endregion

            #region DoWaterJellyfishIntegration(氵母)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoWaterJellyfishIntegration", new() {
                {"Use a Cursed Shard at an altar in the Water Catacombs, it may appear...","在浸水墓穴中的祭壇使用詛咒殘片 它或許會出現..." }
            });
            #endregion

            #region DoSparnIntegration(斯帕恩)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSparnIntegration", new() {
                {"Use a Cursed Shard at an altar in the Trapped Catacombs, it may appear...","在陷阱墓穴中的祭壇使用詛咒殘片，它或許會出現..." }
            });
            #endregion

            #region DoPandorasFireBoxIntegration(潘多拉火焰盒)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoPandorasFireBoxIntegration", new() {
                {"Use a Cursed Shard at an altar in the Fire Catacombs, it may appear...","在烈火墓穴中的祭壇使用詛咒殘片，它或許會出現..." }
            });
            #endregion

            #region DoNiiviIntegration(尼伊維)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoNiiviIntegration", new() {
                {"Deal enough damage to Niivi to anger her, you may find her flying around The Great Illuria! -or sleeping...","對尼伊維造成足夠的傷害後來激怒她.她一般會在星月巨樹附近閑遊-或者在睡覺." }
            });
            #endregion

            #region DoRekIntegration(不熄熾龍 萊克)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoRekIntegration", new() {
                {"Gothivia's sworn protector, you must take him down before you can get to Gothivia.","歌瑟梵的忠衛，只有你擊敗他才有資格挑戰歌瑟梵." }
            });
            #endregion

            #region DoSupernovaFragmentIntegration(破碎超新星)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSupernovaFragmentIntegration", new() {
                {"Go down to the Cinderspark and nag Ordin to get a gift for Ereshkigal and she may give you something in return...","前往燼火之地，向奧丁巴結一份給厄莉什基迦勒的禮物，接受禮物後，她可能會以你想要的東西來報答你." }
            });
            #endregion
        }
    }
}
