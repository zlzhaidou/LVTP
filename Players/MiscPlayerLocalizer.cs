using Stellamod;
using Stellamod.Items.Accessories.Catacombs;

namespace LVTC.Players;

public class MiscPlayerLocalizer : ModSystem
{
    public override void Load()
    {
        #region 進入世界時的消息
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.OnEnterWorld), new() {
<<<<<<< HEAD
            { "[Lunar Veil] Hi hi! Thank you for checking out the mod! If you want more, you can check out my game Diari!", "【穹月天纱作者】你好啊！感谢你游玩我的mod！如果你还想要看看我做的其他东西，上steam搜Diari就好！\n行走的wiki群号：909428503" },
=======
            { "[Lunar Veil] Hi hi! Thank you for checking out the mod! If you want more, you can check out my game Diari!", "【穹月天紗作者】你好啊！感謝你遊玩我的mod！如果你還想要看看我做的其他東西，上steam搜Diari就好！\n漢化交流反饋群號：909428503" },
>>>>>>> e64d9f6a016b60208a4d3b6347c3230045c2c87a
        });
        #endregion
        #region FlamecrestPlayer
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Accessories.Catacombs.FlamecrestPlayer", "BlockVisuals", new() {
            { "Resisted!", "抵抗！" },
            { "The Lunar tree rumbles...", "星月巨樹顫抖著..." },
            { "The Abysm and Virulent stir...", "無盡深淵和瘴煞之地蠢蠢欲動..." },
            { "Azurewrath's dreams alcadize the sky.", "蔚藍之夢將天空魔力化" },
            { "The toxic reunion begins! Gothivia's love bleeds through as the sun burns with everlasting hue.", "恒日高升，歌瑟梵的愛意從中滲出.團聚在即..." },
        });
        #endregion
        #region 某些時候會從玩家頭上彈出的文字
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.PostUpdate), new() {
            { "Wohooo", "蕪湖！" },
            { "Omg, its something!", "哎呦！掉東西了！" },
            { "Are you disappointed? You should be.", "失望嗎？失望就對啦" },
            { "Wow, you have no maidens and no luck..", "幸運女神完全不搭理你呢" },
            { "Sooo lucky!", "幸運！" },
            { "How can someone be so interesting?", "你真有意思！" },
            { "Hiii its a me Bridget your friendly companion :3", "你好~是我呀！你的好夥伴布裏姬！" },
            { "Please dont replace me :(", "請別扔掉我 :(" },
            { "This world is soo pretty! Just like you :p", "這世界好漂亮！和你一樣 :p" },
            { "Im so much better than Lucy :)", "我比露西斧強太多了好嗎！" },
            { "I used to have a roommate, they stink really badly", "我之前和另一個人住在一起過，他身上的味道可重了." },
            { "I love these journeys! I hope you won't throw me away...", "和你一起旅行好開心！不要拋下我哦..." },
            { "Are you gonna get married someday? I'm always an option yknow >~<", "想要結婚嗎？我也是個不錯的選擇哦 >~<" },
            { "When I was in my human form I was the Queen of the uh, morrow? I forgot.", "當我還是人類的時候我是...嗯...幽曦的女王？好像是吧." },
            { "Don't forget to brush your teeth! Its good for you :)", "別忘了刷牙！精氣神一定要好！" },
            { "I completely forgot what it feels like to be flat and everyday you hold me is a reminder.", "我都快忘了我變得這麽扁，但你一把我拿起來我就想起來了." },
            { "I can't tell if I like you holding me or sexual assault.", "你這麽握著我已經算是騷擾了吧" },
            { "I have so many stories I can share to you :)", "我有好多故事要講呢 :)" },
            { "My sister turned me into a sword but I think you can get me out rightttt?", "我姐把我變成了一把劍，你能幫幫我的對吧？" },
            { "I totally don't like you at all, all you did was pull me from a stone yknow :(", "我..我才不喜歡你呢！你不就是把我從石頭裏拔出來了嗎？哼！" },
            { "You're soooo stupid :)", "大傻瓜~ :)" },
            { "I'm you're daily reminder that you aren't alone :p", "我會天天提醒你你不是獨自一人的 :p" },
            { "Hey so will you take me all the way to the end, I've taken a liking to you >:)", "把我帶在身上直到永遠吧，我好喜歡你哦 >:)" },
            { "It's not hehe, its HEHE", "嘻嘻，不嘻嘻" },
            { "I loveee painting, I think I could get back to form if I'm merged with something related", "我超愛畫畫！如果你把我和其它什麽東西合在一起，說不定我的本體就能解放了！" },
            { "Use me for a spin will ya!", "大風車那個吱呦呦地轉~" },
            { "I'm not your normal yandere girl you know, please dont leave me :<", "我才不是傲嬌呢！你別走好嗎 :<" },
            { "It's all fun and games until you get slashed by a dirt sword with boobs", "被一把女性的劍砍可不好受吧？" },
            { "I am so R rated", "我的評級是R" },
            { "Shawty get your head in the game", "寶貝，專心點！" },
            { "Can we get to painting or volleyball pleasee?", "咱可以畫個畫，打打排球什麽的嗎？" },
            { "You're holding me in all the right ways >:)", "被你握著好舒服噢 >:)" },
            { "I dont care what you are, you obviously cared enough to get me :P", "我才不會評價你呢，你都把我從那裏救出來了." },
            { "LALALA you're wrong I'm right LALALALA", "啦啦啦，不聽不聽，啦啦啦~" },
        });
        #endregion
        #region 釣魚時
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.CatchFish), new() {
            { "You feel threatened...", "你感覺到威脅逼近..." },
        });
        #endregion
        #region 死亡信息
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), "CustomDeath", new() {
            { " was consumed by the abyss.", "被深淵吞噬了" },
            { " was contaminated", "被汙染吞並了" },
            { "You touched a black hole... WHAT DID YOU THINK WOULD HAPPEN?", "你覺得觸碰一個黑洞的結果還能是怎樣？？？" },
        });
        #endregion
    }
}
