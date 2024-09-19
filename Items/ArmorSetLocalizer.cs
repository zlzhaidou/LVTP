namespace LVTC.Items;

public class ArmorSetLocalizer : ModSystem
{
    public override void Load()
    {
        ForceLocalizeSystem.LocalizeDerivedByType(typeof(ModItem), nameof(ModItem.UpdateArmorSet), new() {
            { "Stand still to emit a toxic aura!", "站立不動時產生劇毒光環!" }, // AcidHelm, AcidMask, AcidRobe, AcidVisor
            { "\n+1 max minions" +
                "\nThe stars of Illuria protect you!", "\n+1隨從上限\n星樹的明星護佑著你!" }, // AlcaliteMask
            { "You are a true mage..." +
                "\nGain the effects of a mana flower, magic cuffs, and retrieve magic stars from afar " +
                "\nMana costs are reduced by 70% and increased magic regeneration", "你是一名真正的大法師...\n獲得魔力花、魔法手銬的效果，並增加魔力星的拾取範圍！\n減少70%的魔力消耗並提高魔力再生速度" }, // AlsisMask
            { "3, 2, 1 .. Smile! Act like you're on stage will ya :p" +
                "\nEvery little while you'll get a countdown, and when you hear Zero," +
                "\nyour crit is 100% and damage output is doubled! " +
                "\nSmall bits of paint left in your tracks." +
                "\nCrit chance and armor penetration increased by 20!", "3，2，1..大聲笑出來！你就站在舞臺中間！:p\n每隔一小段時間進行一次倒計時，當你聽到「Zero「時\n你將必定暴擊，傷害加倍！\n移動時留下彩墨軌跡\n+20%暴擊率，+20護甲穿透" }, // ArtisanMask
            { "Stars orbit around you\nHit an enemy 5 times to rain down a gigantic star upon them!", "璀璨之星環繞著你！\n攻擊敵人五次來召喚一顆明星從他們上方墜落!" }, // AstrasilkHead
            { "Increases life regen by a great amount!" +
                "\nMove faster and enemies that hit you take damage back! ", "大量增加生命再生速度！\n更快的移速並且攻擊你的敵人會受到反傷！" }, // CelestiaMoonHelmet
            { "Increases life regen by a great amount!" +
                "\nMove faster and gain the effects of magic cuffs! ", "大量增加生命再生速度！\n更快的移速並獲得魔法手銬的效果." }, // CelestiaMoonMask
            { "This armor is really scuffed..." +
                "\nGives the ability of a molten quiver!" +
                "\n-Stuck at 400 max HP, but 20% increased damage for Rangers", "這幅盔甲已經磨損了...\n給予熔火箭袋的效果\n增加20%遠程傷害，但是生命值上限固定為400" }, // DaedenMask
            { "Increases life regen by decent amount!" +
                "\nEnemies become lovestruck when you are hit, or when you hit them!" +
                "\nThis weakens, burns and confuses, slows and does exponential damage " +
                "\nSpirit balls come from a portal on your armor and attack enemies " +
                "\nNo fall Damage " +
                "\nPick up hearts from afar!", "大量增加生命再生!\n當你被擊中或者擊中敵人時，敵人將墜入愛河\n造成虛弱，灼燒，困惑，減速並且減益傷害遞增\n召喚靈魂之球來攻擊敵人\n免疫摔落傷害\n紅心的拾取範圍增加！" }, // DaediaMask
            { "Enemies are less likely to target you!" +
                "\nBlades of Cinder and Rhamenthal will fight alongside you" +
                "\nEvery few seconds you'll gain a major increase to Melee Damage" +
                "\nAn upgraded Govheil set essentially. ", "降低仇恨\n燼火之刃和雷曼索織魔將會與你並肩作戰！\n每過幾秒會大幅度提高你的近戰傷害\n升級後的歌維赫套裝." }, // DucanblitzCap
            { "+1 Max Minions\n+45 Max Life \nHit enemies have a rare chance to be assaulted by angelic power!", "+1隨從上限\n+45最大生命\n擊中敵人有小概率呼喚天使神力對敵人造成重擊！" }, // ElagentHead
            { "Grants immunity to knockback!\n" +
                "When you take a hit, gain a temporary attack speed boost based on the amount of damage you took!", "免疫擊退\n受傷時根據你收到的傷害短暫性增加攻擊速度！" }, // EldritchianHood
            { "Increases life regen by decent amount!" +
                "\nThe armor makes a flowery circle that heals players in it for a large amount!" +
                "\nTurns all your wooden arrows into flower arrows! Which when hitting a target, " +
                "\nsplits into little golden shots that hit back! ", "大量增加生命回復!\n產生一個花圈，大幅治療圈內玩家！\n將你射出的所有木箭變為花箭\n當擊中目標時分裂成小金彈再次擊中！!" }, // FlowerHat
            { "Summons a forest bow to fight for you!", "召喚一把森之弓為你而戰！" }, // ForestCoreHead
            { "Grants immunity to knockback!\n" +
                "+2 Summons", "免疫擊退\n+2隨從上限" }, // GarbageMask
            { "Enemies are less likely to target you!" +
                "\nGovheil blades will come to defend you!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Summon damage" +
                "\n+2 Summons!", "降低仇恨\n歌維赫之刃將會保護你\n每過幾秒會大幅提高你的魔法和召喚傷害\n+2隨從上限" }, // GovheilHelmet
            { "Enemies are less likely to target you!" +
                "\nMagical Govheil bows will come to your aid!!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Summon damage" +
                "\n+2 Summons!", "降低仇恨\n歌維赫魔能弓將會隨你而戰\n每過幾秒會大幅提高你魔法和召喚傷害\n+2隨從上限" }, // GovheilMask
            { "2 Gintze Guards come to fight for you" +
                 "\n+1 Summons!", "召喚兩個玄鐵護衛來給你而戰\n+1隨從上限" }, // HeavyMetalHead, GintzeMask
            { "Increases life regen by a big amount!" +
                "\nReduced Healing Flask cooldown" +
                "\nDOES NOT STACK with philosophers stone", "大量增加生命回復\n減少治療藥水的冷卻時間\n不能與點金石疊加" }, // HuntrianHelmet
            { "Enemies are less likely to target you!", "降低仇恨" }, // IllurianCrestmask
            { "Allows you to walk on water", "允許你在水上行走" }, // IllurianWarriorHelm
            { "Increases life regen by a great amount!" +
                "\nMove faster and go along with the watery winds." +
                "\nSummons in watery dragons to come and swirl around your character." +
                "\nThese dragons emit a great becoming amongst the lost dynasty and give 50 Health." +
                "\nThis aura also lessens enemy damage by 10% and damages enemies." +
                "\nEnemies are less likely to target you!", "大量增加生命回復度\n增加移動速度，與水流和迅風同行\n召喚水龍魂圍繞你盤旋\n這些龍魂散發出失落的王朝中的巨大能量，並給予50點生命值\n它們會吸收10%的敵人傷害，並且對觸碰到的敵人造成大量傷害！\n降低仇恨！" }, // JianxinMask
            { "Increases life regen by an enormous amount!" +
                "\nEnemies become lovestruck when you are hit, or when you hit them!" +
                "\nThis weakens, burns and confuses, slows and does exponential damage ", "大量增加生命回復!\n當你被擊中或者擊中敵人時，敵人將墜入愛河\n造成虛弱，灼燒，困惑，減速並且減益傷害遞增" }, // LovestruckMask
            { "Increases life regen" +
                "\nTake 10% Less damage", "增加生命回復\n減少10%所受傷害" }, // MardenthMask
            { "Increases summon damage by 16%"+
                "\n+2 Max Sentries" +
                "\nYour attacks have a chance to cleave out a part of the enemy's soul" +
                "\nCollect these to gain a stacking increase to your whip speed and summon damage!" +
                "\nTaking damage resets the stack", "+16%召喚傷害\n+2哨兵上限\n你的攻擊可以撕裂敵人的靈魂\n收集靈魂碎片將會增加你的揮鞭速度和召喚傷害\n當你受到傷害時會重置此效果" }, // MiracleHead
            { "Increases life regen by a great amount!" +
                "\nMove faster and have less aggro and less enemies spawn around you!", "大量增加生命回復\n移速更快！仇恨降低！敵人更少！" }, // ScissorianMask
            { "Summons a turret over your head to shoot a laser at nearby enemies!\n8% increased magic and summon damage", "在頭頂上召喚一個哨兵，向附近的敵人發射激光\n+8%魔法和召喚傷害" }, // ScrappyHead
            { "Become greatly empowered for a short time when low on health!\nJust one last breath...", "生命值跌落太低時獲得暫時的強大屬性提升\n回光返照？" }, // ShadeWraithHead
            { "Immunity to fall damage!", "免疫摔落傷害" }, // StoniaHat
            { "You build up magical crit chance over time!\n" +
                "+20 Max Life", "魔法暴擊率逐步提高\n+20最大生命" }, // TerricHead
            { "Increases life regen" +
                "\nAnyone that touches you gets an ATD (Astolfo Transmitted Disease)", "增加生命回復\n使所有觸碰你的人罹患ATD（阿斯托弗傳染病）" }, // AstolfoMask
            { "Auto gain the abilities of Magic cuffs and Mana Flower!" +
                "\nEnemies will be attacked by your power of music!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Ranged damage!", "獲得魔法手銬和魔力花的效果\n喚起音韻之力痛擊你的敵人！\n每過幾秒鐘，你的魔法和遠程傷害將大幅提升！" }, // VerlHat
            { "Auto gain the abilities of a Magic Quiver and +5% Ranged damage" +
                "\nEnemies will be attacked by your power of music!" +
                "\nEvery few seconds you'll gain a major increase to Ranged and Magic damage!", "獲得魔法箭袋的效果並增加5%遠程傷害\n喚起音韻之力痛擊你的敵人！\n每過幾秒鐘，你的魔法和遠程傷害將大幅提升！" }, // VerlMask
            { "Gain the accessory effects of desert boots!" +
                "\nAutomatically run at fast speeds without boots! " +
                "\n +3 Defense!", "獲得沙丘行者靴的效果\n無需靴子即可高速行走！\n+3防禦力" }, // VextinMask
            { "I am wind in a million" +
                "\n30% Increased throwing attack speed!" +
                "\nHighly increased throwing weapon knowckback", "「夫物蕓蕓，各復歸其根.」\n+30%投擲速度\n大幅增加投擲武器的擊退" }, // WindmillionHat
            { "Up to three icicles surround you to protect you from attacks!", "冰錐會出現在你身邊保護你，最多三只" }, // WinterbornHead
            { "Truly a giver of society! The witches respect you :P" +
                "\nGain the effects of a mana flower, magic cuffs" +
                "\nExtreme mana regeneration" +
                "\nMana costs are reduced by 50%" +
                "\nFlowery Rhythm!", "你對社會做出了巨大的貢獻！女巫們會尊重你！\n獲得魔力花和魔法手銬的效果\n極高的魔力回復\n魔力消耗減少50%\n花之韻律！" }, // WitchenHat
            { "Gain the accessory effects of desert boots!" +
                "\nAutomatically run at fast speeds without boots! " +
                "\n +5 Defense!"+
                "\nGain the effects if Forbidden armor!" +
                "\nArrows are heated up with the effects of a molten quiver!", "獲得沙丘行者靴的效果\n無需靴子即可高速行走\n+5防禦力\n獲得禁戒套裝的效果\n擁有熔火箭袋的效果，將木箭點燃" }, // XexterianHat
        });
    }
}
