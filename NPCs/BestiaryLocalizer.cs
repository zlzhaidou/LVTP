namespace LVTC.NPCs;

public class BestiaryLocalizer : ModSystem
{
    public override void Load()
    {
        ForceLocalizeSystem.LocalizeDerivedByType(typeof(ModNPC), nameof(ModNPC.SetBestiary), new() {
            #region Bosses

            { "Powerful skulls sent by skeletron to roam the darkness for the next pray", "由骷髏王統領的小型骷髏頭，在黑暗中尋找下一名受害者." }, // AbysmLunatic, ShadowWraith

            { "A scarecrow reanimated by the passion of wandering flames", "一只稻草人，被漂浪火焰中的熱情喚醒." }, // Azurerin, Caeva, SolarPortal, GintziaHand
            
            { "One who followed power, exchanging their freedom for a taste of a singularity. Trapped forever guarding whats left of the Govheil.", "力量的追隨者，甘願獻出自己的生命與自由成為奇點的容器，作為守衛被永世封印於歌維赫的殘骸中." }, // DaedusR
            { "The aspiring forgotten puppet", "渴求力量的石偶" }, // DaedusR
            { "A small singularity granted to Daedus in exchange for where he lives and protects for.", "一顆小型奇點，便換來了他的永世忠誠守護" }, // SolarSingularity

            { "A crystal which holds the power of summoning one of the three deities", "一顆水晶，具有喚醒天紗三神之一的力量." }, // BloodCyst, DreadMonolith, GraveShard
            { "One of the three powerful cosmic deities that has been tainted by devilish intent", "天紗三神之一，其力量被不潔意圖汙染." }, // DreadMire
            { "Traded her singularity in turn for more dreadful power, ridden of anxiety and all things dreadful", "她主動放棄了自己的奇點，換來了這令人恐懼的魔法，將不安與驚惶散步整個大陸." }, // DreadMireR
            { "Cozmire- Dreadmire Veil??", "天寰——等等，絳淵惡巫？" }, // DreadMireR
            // 這個字符哪來的? 我不知道. 反正它不是亂碼, 原文就長這樣
            { "Powerful skulls tainted by devilish intent (dreadmire must誺e got bored with this one)", "強力的骷髏仆從，被邪惡力量侵蝕." }, // DreadSurvent
            { "The heart of the beast brought on by devilish intent\r\n(How the hell does that thing fit inside her chest?)", "驚懼力量之心\r\n（她的胸膛裏怎麽裝得下這麽個東西？？？）" }, // DreadMiresHeart
            
            { "A mystical veil user who took accountability to chain up Sigfried", "禁錮了齊格飛的神秘人物" }, // EreshkigalIdle
            { "Ereshkigal the Lover", "癡戀者厄莉什基迦勒" }, // EreshkigalIdle
            
            { "Searching for a lover, this particular Queen lacks anyone she can socialize with as she tries to gain power of the void to kill Sigfried for revenge, so much power yet so lonely.", "這名皇後幾乎封閉了自我，在積蓄力量對齊格飛發起復仇的途中她舍棄了幾乎其他一切.強大而孤獨." }, // Fenix
            { "Fenix the Vengeful", "逐仇者，緋琦" }, // Fenix
            
            { "This person isn't the real gothivia, where is she?", "這不是真的歌瑟梵.她在哪？" }, // Gothiviab
            { "I guess she knows you destroyed her singularity inside Daedus, oops", "看來她已經知道你摧毀了代達斯和那顆奇點.哎呦." }, // Gothiviabb
            { "A loving little pet of the sun goddess Gothivia", "歌瑟梵的小寵物." }, // Rek
            { "A part of gothivia's largest creations", "歌瑟梵最宏偉的造物的一部分." }, // Train1, Train2
            
            { "You sense a strange godly prescence coming from Gothivia", "你從歌瑟梵身上感受到一股...神聖的氣息." }, // GothiviaIdle
            { "Start to something bad", "一件惡事的開端" }, // StartGoth, StartIrradia
            { "A special snake from the Cinderspark that was atop it's food chain and took a liking to Gothivia. Eventually it became her guardian.", "燼火之地的一條盤龍，端坐食物鏈頂端.對歌瑟梵有特別的好感，甚至成了她的貼身護衛." }, // RekSnake
            { "Rek, The Sun Serpent", "熾陽盤龍 萊克" }, // RekSnake
            
            { "A abomination housing the eggs for what seems to be a mechanical bird, born from the acid and a creation of Gia.", "一個扭曲的造物.其中裝著一顆卵，看上去是機械製成的.吉婭結合了酸蝕之地的作品." }, // IrradiatedNest
            { "Irradiated Nest", "輻射巢穴" }, // IrradiatedNest 
            
            { "The most committed protector of the Govhiel. She just wishes to see her friend's and village again.", "歌維赫堡最忠實最固執的守護者.她僅有的願望是再次見到她的親人與家園." }, // Irradia
            { "Irradia N Havoc", "伊瑞蒂安與浩劫龍械" }, // Irradia
            { "A suspicious person at the bottom of the Govheil Castle", "歌維赫堡深處的神秘人物" }, // IrradiaIdle
            
            { "A scarecrow reanimated by the passion of wandering flames, exploring out of the veil.", "一只稻草人，被漂浪火焰中的熱情喚醒.在天紗之外的凡塵中遊蕩." }, // Jack
            
            { "Niivi, The First Dragon", "太初祖龍，尼伊維" }, // Niivi
            
            { "A poisonous slime mutated from normal green slimes", "曾經是一只普通的綠史萊姆，在酸蝕之地變異成了此毒物." }, // LazerOrb, SingularityOrb, SupernovaOrb, DreadFireCircle
            { "A powerful gift that was given to Cozmire, yet was stolen away by Fenix to seal away Verlia.", "天寰神巫獲贈的寶物，被緋琦盜走後用於封印薇莉婭." }, // SingularityFragment
            { "Singularity Fragment", "破碎奇點" }, // SingularityFragment
            
            { "Destruction is what these bring, Fenix may of purchased some things off the black market, destroy these immediately...", "毀滅是此物唯一的用途.緋琦可能是在黑市買到的它們，見到它一定要悉數摧毀." }, // STARBOMBER
            { "STARBOMBER", "星 爆 者" }, // STARBOMBER
            
            { "A beloved magical stone guardian, protected the natural life and would petrify anyone who disturbs it.", "一具倍受喜愛的魔力石偶，保衛著自然生靈，擅闖者統統被其化作頑石." }, // StarrVeriplant
            
            { "Former flyer and born where all big birds were born, in the cinderspark.", "曾經的空中猛將，與所有巨鳥一樣，出生於燼火之地." }, // SunStalker
            { "SunStalker, the Last Talon", "風沙遺爪，獵日遊隼" }, // SunStalker
            
            { "A powerful gift from Lumi V. to her trusted sisters.", "天紗琉明給予她姐妹的禮物." }, // SupernovaFragment
            { "Supernova Fragment", "破碎超新星" }, // SupernovaFragment
            
            { "Someone who was consumed by their dark magic, even more so than Fenix would bother with.", "一個被黑暗魔法吞噬的人，甚至比緋琦還要走火入魔." }, // Sylia
            { "Sylia, Merena's Sister.", "賽莉亞，梅瑞娜的妹妹" }, // Sylia
            { "A strange rift to void, disturbing it may yield catastrophic results...", "一個怪異的虛空裂縫，擾動它可能會產生災難性的後果......" }, // UnderworldRift
            
            { "Clone of a powerful sexy goddess :)", "一個強力存在的克隆體:)" }, // CloneV, DeathVerlia, StarteV
            
            { "???", "???" }, // GothiviaIdle, IrradiaIdle

            #endregion

            { "Burining with passion I guess.", "我想是在燃燒著自己的芳華吧." }, // BlazingSerpentHead
            { "They guard what is theirs!", "他們捍衛著屬於他們自己的東西." }, // BlazingSerpentHead
            { "The most adorable goodest spicy child. Do not dare be mean to him!", "最可愛最好的小家夥！不要對它們那麽殘忍！" }, // SandWalker, SnowWalker
            { "He's evil yet so weak. This fellow betrayed Gothivia during their war against Fenix and his part of the army joined the other side for power.", "他很邪惡，但又是個紙老虎.這家夥在與緋琦的戰爭中背叛了歌瑟梵，他的軍隊加入了另一方去爭奪權力." }, // CommanderGintzia
            { "Commander Gintzia, the betrayer", "變節者，金戈亞指揮官" }, // CommanderGintzia, GintziaHand
            { "A Captain of Gothivia's ranks, be careful", "歌瑟梵麾下的隊長！需謹慎應對" }, // GintzeCaptain
            { "A Captain of Gofria's ranks, be careful", "歌瑟梵麾下的士兵！需謹慎應對" }, // GintzeSolider
            { "Lowest of the Gintze but can wipe you out fast! They need food too yknow :(", "最低等的玄鐵士兵，但仍然致命！他們也需要吃飯的呀 :(" }, // Gintzling
            { "The highest form of worshippers of Gothivia corrupted and risen from the grounds of the fallen Govheil Castle", "在不復往日的歌維赫堡，昔日歌瑟梵最虔誠的崇拜者在腐疫的驅使下，再次起身為其而戰." }, // Tulacrowe
            { "A lowly civilian who bought old parts from Irradia before being contaminated. They now seek revenge after having their minds altered by the acid.", "一位在被汙染之前常常從伊瑞蒂安購買舊零件的卑微平民。酸蝕腐化了他的心智，促使著他尋求報復." }, // IrravheilSprayer
            { "Guardians who are ready to die for Gothivia?", "心甘情願為歌瑟梵獻出生命的守衛" }, // GovheilGuardian
            { "The last protectors of the govheil, and they are pretty formidable...", "歌維赫堡最後的保護者，他們不容小覷..." }, // GovheilProtector
            { "A respected sorcerer from Sigfried's old rein", "一名來自齊格飛時代受人尊敬的魔法師" }, // IllurianMage
            { "Extremely powerful jellyfish that has been aflicted by the gild in the morrow, very dangerour", "一只異常強大的水母，受幽曦的力量影響後變得更加危險." }, // MorrowedJellyFish
            { "Even the weakest, most poor among the warriors in the morrow are still decent foes..", "即使是幽曦戰士中最弱小、最貧窮的人，仍然是可怕的敵人." }, // TribalPeasant
            { "A much richer form of the trible worshippers", "部族崇拜者中的佼佼者" }, // TribalPriest
            { "The slime kings Royal heir, it will take his place opon death...", "史萊姆王室的繼承者，在史萊姆王退位後將由它來接替王位..." }, // RoyalSlime
            { "A slime formed of pure darkness conjured by powerful beasts", "由純粹黑暗凝聚成的凝膠狀生命體，由某個強大的怪物召喚而來." }, // ShadeSlime
            { "A strange lady, she seems to overflow with magical energy!", "一名奇怪的女士.她身上的魔力幾乎滿溢..." }, // LonelySorceress
            { "Lonely Feeble Sorceress", "孤獨可憐的魔法少女." }, // LonelySorceress
            { "An old rusted cog with some magical abilities", "一個生銹的齒輪，或許有一些神奇的能力." }, // Rustwork
        });
    }
}
