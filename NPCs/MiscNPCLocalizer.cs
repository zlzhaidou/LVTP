using Stellamod.NPCs.Abyssal;
using Stellamod.NPCs.Bosses.Azurerin;
using Stellamod.NPCs.Bosses.Caeva;
using Stellamod.NPCs.Bosses.DaedusRework;
using Stellamod.NPCs.Bosses.DreadMire;
using Stellamod.NPCs.Bosses.DreadMire.Heart;
using Stellamod.NPCs.Bosses.DreadMire.Monolith;
using Stellamod.NPCs.Bosses.Ereshkigal;
using Stellamod.NPCs.Bosses.Fenix;
using Stellamod.NPCs.Bosses.GothiviaNRek.Gothivia;
using Stellamod.NPCs.Bosses.GothiviaNRek.Reks;
using Stellamod.NPCs.Bosses.GothiviaTheSun.GOS;
using Stellamod.NPCs.Bosses.INest;
using Stellamod.NPCs.Bosses.IrradiaNHavoc;
using Stellamod.NPCs.Bosses.IrradiaNHavoc.Irradia;
using Stellamod.NPCs.Bosses.Jack;
using Stellamod.NPCs.Bosses.Niivi;
using Stellamod.NPCs.Bosses.singularityFragment;
using Stellamod.NPCs.Bosses.STARBOMBER;
using Stellamod.NPCs.Bosses.StarrVeriplant;
using Stellamod.NPCs.Bosses.SunStalker;
using Stellamod.NPCs.Bosses.SupernovaFragment;
using Stellamod.NPCs.Bosses.Sylia;
using Stellamod.NPCs.Bosses.Verlia.Projectiles;
using Stellamod.NPCs.Catacombs.Fire;
using Stellamod.NPCs.Critters;
using Stellamod.NPCs.Event.Gintzearmy.BossGintze;
using Stellamod.NPCs.RoyalCapital;
using Stellamod.NPCs.Underground;

namespace LVTC.NPCs;

public class MiscNPCLocalizer : ModSystem
{
    public override void Load()
    {
        #region 某些 NPC 死亡時的消息
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Global.NPCMessages", "OnKill", new() {
            { "Zui has something to offer you...", "蕊有東西要給你！" },
            { "The Lunar tree rumbles...", "星月巨樹顫抖著..." },
            { "The Abysm and Virulent stir...", "無盡深淵和瘴煞之地蠢蠢欲動..." },
            { "Azurewrath's dreams alcadize the sky.", "蔚藍之夢將天空魔力化" },
            { "The toxic reunion begins! Gothivia's love bleeds through as the sun burns with everlasting hue.", "恒日高升，歌瑟梵的愛意從中滲出.團聚在即..." },
        });
        #endregion
        #region DesertRune
        ForceLocalizeSystem.LocalizeByTypeName("DesertRune", "HitEffect", new() {
            { "Desert Harvest Collected!", "收集了沙漠符文！" },
        });
        #endregion
        #region IceRune
        ForceLocalizeSystem.LocalizeByTypeName("IceRune", "HitEffect", new() {
            { "Ice Harvest Collected!", "收集了雪地符文！" },
        });
        #endregion
        #region JungleRune
        ForceLocalizeSystem.LocalizeByTypeName("JungleRune", "HitEffect", new() {
            { "Jungle Harvest Collected!", "收集了叢林符文！" },
        });
        #endregion
        #region OceanRune
        ForceLocalizeSystem.LocalizeByTypeName("OceanRune", "HitEffect", new() {
            { "Ocean Harvest Collected!", "收集了海洋符文！" },
        });
        #endregion
        #region OverworldRune
        ForceLocalizeSystem.LocalizeByTypeName("OverworldRune", "HitEffect", new() {
            { "Overworld Harvest Collected!", "收集了地表符文！" },
        });
        #endregion
        #region PearledGold
        ForceLocalizeSystem.LocalizeByTypeName("PearledGold", "HitEffect", new() {
            { "Veriplant Harvest Collected!", "收集了殆綠符文！" },
        });
        #endregion
        #region SkyRune
        ForceLocalizeSystem.LocalizeByTypeName("SkyRune", "HitEffect", new() {
            { "Sky Harvest Collected!", "收集了天空符文！" },
        });
        #endregion
        #region RedFlower
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(RedFlower).FullName, "HitEffect", new() {
            { "Flower destroyed", "收集了花束" },
        });
        #endregion
        #region WhiteFlower
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(WhiteFlower).FullName, "HitEffect", new() {
            { "Flower destroyed", "收集了花束" },
        });
        #endregion
        #region LonelySorceress
        ForceLocalizeSystem.LocalizeByType(typeof(LonelySorceress), "GetChat", new() {
            { "I wanna be like her", "我想要變成她那樣" },
            { "Mmm it's soo nice to meet you, wanna play with me :3", "見到你真好啊，想要和我玩玩嗎 :3" },
            { "I'm all alone in this castle, if only someone could have fun with me :> ", "天天呆在這城堡裏，好寂寞哦..." },
            { "Mwhahahahaha I am the most evil sorceress on the planet!!!", "啊哈哈哈哈哈哈哈哈！我就是這個星球上最邪惡的魔法少女！！！" },
            { "Obviously I want you to stay! Can you just stay here for a while- no, forever? I mean it isn't too much of an ask. ", "我當然想要你留下啦！你能在這陪我一會...到永遠嗎？這不是什麽大問題吧." },
            { "There were these two that came by, one of them looked like me and had fox ears too! I wonder what breed she is.", "之前有兩個人從這路過，其中一個和我長得很像，甚至也有狐貍耳朵！我想認識認識她." },
            { "This place can be shared by only us two you know, you can be here for me :)", "你搬過來住吧！這樣這裏就只有我們兩個啦！" },
            { "Nobody really gets me you know, but I can see it in your eyes, we'll be made for each other :p", "沒有人理解我，但我從你的眼睛裏能看得出，咱倆就是天作之合！" },
            { "I think if you want to, maybe we can spar??? It would be so fun with you!", "如果你想的話，咱們來玩玩吧！" },
            { "I think this place is accidently communistic...", "這裏好像不小心變成共產主義國家了..." },
            { "Where did that Carian tome go?", "那本古籍哪去了？" },
            { "Hii babe! Can we pleaseee fight? I haven't been able to do anything for sooo long and I just wanna have fun but nobody lets me do anything around here, so pretty pleasee", "嗨~寶貝~能和我打一架嗎？我在這裏無所事事好長時間了，沒人跟我玩...求求你啦！" },
            { "Funny enough I'm actually older than I act, take a guess I bet you didn't answer 26 lol!!", "我的年紀比看起來高哦~猜猜看？你肯定猜不中26的哈哈哈！" },
            { "Shhh hush hun, we should try to spar instead :3", "噓，無需多言，來切磋一番吧！:3" },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(LonelySorceress), "SetNPCNameList", new() {
            { "Lonely Feeble Sorceress", "孤獨可憐的魔法少女" },
            { "Lonely Feeble Sorceress", "孤獨可憐的魔法少女" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(LonelySorceress), "SetChatButtons", new() {
            { "Spar with your new wife", "和你的新老婆切磋一番！" },
        });
        #endregion

        #region Bosses

        #region BloodCystDead
        ForceLocalizeSystem.LocalizeByType(typeof(BloodCystDead), nameof(BloodCystDead.AI), new() {
            { "...", "..." },
            { "The dread shrouds you...", "恐懼纏絞著你..." },
            { "Darkness...", "黑暗湧動..." },
        });
        #endregion

        #region EreshkigalIdle
        ForceLocalizeSystem.LocalizeByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.GetChat), new() {
            { "Leave me and my husband alone", "讓我和我的丈夫在這裏獨享二人時光吧" },
            { "You should all be jealous that I'm here.", "你們都應該羨慕我！" },
            { "Welcome welcome! Come here to feast your eyes on us?", "歡迎！歡迎！來一飽眼福吧" },
            { "Oh dear Sigfried how we've met..", "親愛的齊格飛...我還記得我們相遇的那天..." },
            { "Come and go you will, you'll be broken more than the others.", "匆忙的來，匆忙的走，將自己搞得支離破碎..." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.SetNPCNameList), new() {
            { "Ereshkigal the Lover", "癡戀者厄莉什基迦勒" },
            { "Ereshkigal the Lover", "癡戀者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.SetChatButtons), new() {
            { "Give her something.", "給她送一件禮物" },
            { "Sigfried?", "詢問關於齊格飛" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.OnChatButtonClicked), new() {
            { "OMG, OMG OMG OMG OMG", "天哪天哪天哪天哪！！" },
            { "What is this? Nothing of importance to me... You are worthless, you're life is as valuable as a cinderspark summer ant, you mean nothing. You should get me something good NOW. You should burn in the Cinderspark..", "這是什麽...不要緊，它和你一樣毫無用處，像一只螞蟻一樣不值一提.趕緊給我找到點有價值的東西，不然我就把你扔到燼火之地永世焚燒." },
            { "Oh what a darling he is. Too bad I'm tasked with keeping him here forever right? He can't escape me :3 ", "我的任務就是把他永遠關在這裏，對他來說可不是什麽好消息對吧 :3" },
            { "Sigfried is my husband you know. We met on the sacred lands of the Illuria, I may have been kicked out numerous times to talk to my king but I'd do anything to get with him", "我丈夫就是齊格飛.我們初次見面是在星樹的聖地，我已經被他的守衛趕出那裏不知道多少次了，但為了他這一切都值得." },
            { "He's so pure, going for such high level threats such as Lumi and stealing her singularity. That's the type of man I like, one who isn't afraid to get their hands dirty.", "他是那麽的純粹，敢向琉明那樣的高級威脅下手，還偷走了她的奇點！我就喜歡這種幹事幹凈利落毫無顧忌的男人." },
            { "I wish we could stay together always.", "我們要永遠在一起~" },
            { "Oh his dear Mordred, I bet he doesn't even know hit wife was trapped within a weapon :)", "哦，那個莫德雷德呀...我敢肯定他都不知道他的妻子已經被囚禁在一把武器裏了." },
            { "Stupid dragon always getting in the way to getting to my wonderous babe, I would trap it as well but then it'd anger my dearest here.", "那條蠢龍，總是守著我的寶貝不讓我靠近...要不是我丈夫會生氣，我早就把那龍也關到這裏了." },
            { "How many doors do I need to store Lumi? I don't really know but I don't care. As long as she doesn't come after my husband.", "我要用多少扇門才能困住琉明？算了，也不重要，只要她不來找我的丈夫就行." },
        });
        #endregion

        #region GothiviaDeath
        ForceLocalizeSystem.LocalizeByTypeName(nameof(GothiviaDeath), "AI", new() {
            { "Stoppp~", "停——" },
            { "I'm cant-", "我不——" },
        });
        #endregion
        #region GothiviaIdle
        ForceLocalizeSystem.LocalizeByType(typeof(GothiviaIdle), nameof(GothiviaIdle.GetChat), new() {
            { "...", "..." },
            { "I shouldn't have left..", "或許我就不該離開..." },
            { "Verlia.. Irradia...", "薇莉婭...伊瑞蒂安..." },
            { "A monster you are", "你真是個怪物" },
            { "...Interesting...", "...有點東西..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(GothiviaIdle), nameof(GothiviaIdle.SetNPCNameList), new() {
            { "Gothivia The Enraged", "盛怒烈陽 歌瑟梵" },
            { "Gothivia The Enraged", "盛怒烈陽 歌瑟梵" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(GothiviaIdle), nameof(GothiviaIdle.SetChatButtons), new() {
            { "Challenge.", "挑戰" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(GothiviaIdle), nameof(GothiviaIdle.OnChatButtonClicked), new() {
            { "You're not worth the effort, Rek can avenge them for me. Idiot.", "讓萊克為她們復仇吧.對付你不需要我親自出手，蠢貨." },
        });
        #endregion

        #region IrradiatedNest
        ForceLocalizeSystem.LocalizeByTypeName(nameof(IrradiatedNest), "AI", new() {
            { "Significant damage detected...", "檢測到嚴重損傷..." },
            { "deploying Communication transmission device", "啟動通訊裝置" },
            { "Transmission successful!", "成功連接！" },
            { "Back up vessel destroyed...", "後備機體已被摧毀..." },
            { "Proceed with D. S. D. P!", "運行程序 D.S.D.P.！" },
        });
        #endregion

        #region IrradiaIdle
        ForceLocalizeSystem.LocalizeByType(typeof(IrradiaIdle), nameof(IrradiaIdle.GetChat), new() {
            { "...", "..." },
            { "Leave before you too become corrupt", "在你也被腐化之前離開這裏" },
            { "Get away from here.", "滾出這裏." },
            { "I miss them", "我想她們..." },
            { "... Delgrim...", "...戴爾格林..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(IrradiaIdle), nameof(IrradiaIdle.SetNPCNameList), new() {
            { "???", "???" },
            { "???", "???" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(IrradiaIdle), nameof(IrradiaIdle.SetChatButtons), new() {
            { "Show Verlia's Manifested Bravery", "展示薇莉婭的靈魂核心" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(IrradiaIdle), nameof(IrradiaIdle.OnChatButtonClicked), new() {
            { "Stop bothering me, you don't deserve to die.", "別來煩我.你都不值得被我親手殺死." },
        });
        #endregion

        #region StarrVeriplant
        ForceLocalizeSystem.LocalizeByType(typeof(StarrVeriplant), "Pulse", new() {
            { "Weak!", "虛弱！" },
            { "Armor Broke!", "護甲破碎！" },
            { "Player Wrath UP!", "玩家怒氣加成！" },
            { "Player Speed UP!", "玩家速度加成！" },
        });
        #endregion

        #region SunStalkerPreSpawn
        ForceLocalizeSystem.LocalizeByType(typeof(StarrVeriplant), nameof(StarrVeriplant.AI), new() {
            { "The Sun...", "烈日..." },
        });
        #endregion

        #region UnderworldRift
        ForceLocalizeSystem.LocalizeByType(typeof(UnderworldRift), nameof(UnderworldRift.GetChat), new() {
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(UnderworldRift), nameof(UnderworldRift.SetNPCNameList), new() {
            { "Underworld Rift", "地獄裂隙" },
            { "Underworld Rift", "地獄裂隙" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(UnderworldRift), nameof(UnderworldRift.SetChatButtons), new() {
            { "Disturb Rift", "試探裂隙" },
        });
        #endregion

        #endregion

        #region DiceinNPC
        ForceLocalizeSystem.LocalizeByTypeName("DiceinNPC", "AI", new() {
            { "Wohooo", "蕪湖！" },
            { "Omg, its something!", "哎呦！掉東西了！" },
            { "Are you disappointed? You should be.", "失望嗎？失望就對啦" },
            { "Wow, you have no maidens and no luck..", "幸運女神完全不搭理你呢" },
            { "Sooo lucky!", "幸運！" },
            { "WHATTT, you should not be this lucky..", "你怎麽這麽幸運？開掛了吧！" },
            { "Pfffft HAHA, laugh at this user.", "噗——哈哈哈！真是個倒黴蛋！" },
            { "Sometimes, you just have to tie your hair back and get on your knees.", "有時，你就該乖乖接受事實" },
            { "Womp womp", "嘟嘟~" },
            { "NOW THIS IS AMAZEBALLS", "震撼人心！" },
        });
        #endregion
    }
}
