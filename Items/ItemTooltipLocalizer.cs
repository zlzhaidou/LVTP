using Stellamod.Items;
using Stellamod.Items.Accessories.Brooches;

namespace LVTC.Items;

public class ItemTooltipLocalizer : ModSystem
{
    public override void Load()
    {
        Dictionary<string, string> localizations = new() {
            { "Simple Brooch!", "簡易飾符!" },
            { "Use with caution...", "謹慎使用..." },
            { "May cause disaster", "可能導致災難性的後果" },
            { "Advanced Brooch!", "高級飾符！" },
            { "You need an Advanced Brooches Backpack for this!", "你需要高級飾符背包才能讓此飾品發揮效果！" },
            { "Radiant Brooch!", "輝映飾符！" },
            { "I shall arrive with you soon - Gintzia", "馬上到你家門口 ——金戈亞" },
            { "This'll drive you insane for one minion", "為了一個隨從欄位，至於嗎？" },
            { "A+ Accessory!", "超級棒的飾品！" },
            { "S+ Accessory!", "比超級棒更棒的飾品！" },
            { "You need an Radiant Brooches Backpack for this!", "你需要輝映飾符背包才能讓此飾品發揮效果！" },
            { "Love you and have fun -Sirestias", "愛你喲，玩的開心！ ——希絲忒莉亞" },
            { "Please check out my game Diari!", "有空的話也請去看看我的遊戲Diari！" },
            { "This mod is in relation to the game", "此mod的劇情與它有聯系" },
            { "Can be changed to", "可使用寶珠轉化為" },
            { "(A)Honestly could wipe out many wide varieties of enemies!", "（A）威力強勁，橫掃千軍！" },
            { "(A) Extremely good for targeting! Needs an enemy alive to work!", "敵人無可遁形！前提是要有敵人" },
            { "(A+) Strikes enemies with some straight ass star power!", "（A+）引導繁星之力，降下天罰！" },
            { "Greatsword Weapon Type", "武器類型：巨劍" },
            { "(A) Very High Damage Scaling with frost explosions!", "（A）很高的冰霜爆炸傷害修正！" },
            { "(A) Very High Damage Scaling with knives!", "（A）很高的飛刀傷害修正！" },
            { "Stein Weapon Type", "武器類型：沖擊拳套" },
            { "The sorrowing souls within are crying", "聆聽那靈魂的哀嚎..." },
            { "This weapon is bound by Fenix", "緋琦的力量纏繞於其上" },
            { "(S) Explosion damage is out of this world!", "（S）超神的爆炸傷害修正！" },
            { "(A) Honestly could wipe out many wide varieties of enemies!", "（A）威力強勁，橫掃千軍！" },
            { "A weapon so powerful, it holds a gravitation pull and can change forms!", "有股力量將周圍的一切吸向它...還可以改變形態！" },
            { "Right click for a powerful gravitation slam!", "右鍵釋放強力俯沖猛砸地面！" },
            { "(S) Use your right click to switch between 4 forms!", "右鍵在4個形態中切換！" },
            { "(S+) Godlike High Damage Scaling with the power of the sun!", "（S+）駕馭烈陽之力，展現神威！" },
            { "Multiplication and cloning is the essense of power nyaaa!", "復製，克隆，這正是力量的精華展現喵！！！" },
            { "(B) Good Damage scaling with scythe blades!", "（B）不錯的鐮刃傷害修正！" },
            { "Right click to change form, requires a Sewing Kit", "右鍵變化形態，需要裝備織影套件包" },
            { "Changed by Sewing Kit, effects may be incorrect...", "形態發生了扭曲轉變..." },
            { "Safunai Weapon Type", "武器類型：鞭刃" },
            { "(C) Medium Damage Scaling wind shots On Hit!", "（C）中等的風之矢傷害修正" },
            { "(B) Medium Damage Scaling (Frost balls) On Hit!", "（B）中等的冰霜球傷害修正" },
            { "(S) Great Damage scaling with swings!", "（S）極高的揮動傷害修正！" },
            { "(A) 3 Weapons in one!", "三武合一，何等便利！" },
            { "(A) Use your right click to switch between 3 forms!", "右鍵在3個形態中切換！" },
            { "(D) Low Damage scaling for Skulls on hit", "（D）低的骷髏頭的傷害修正" },
            { "(B) Great spread on bullets", "（B）子彈較為發散" },
            { "Gun Holster Weapon Type", "武器類型：槍套" },
            { "Use to equip to your gun holster's right hand!", "左鍵來將它裝備至你的槍套右手！" },
            { "You do not have a Gun Holster...", "你並沒有槍套..." },
            { "Buy one from Delgrim!", "去向戴爾格林買一個吧！" },
            { "(A) Great stacking and holding damage, less immunity frames!", "（A）傷害隨按住堆砌得更高，且造成無敵幀更少！" },
            { "(S) Extreme damage scaling with the love sword!", "（S）極高的愛之劍傷害修正！" },
            { "Use to equip to your gun holster's left hand!", "左鍵來將它裝備至你的槍套左手！" },
            { "OR right click to equip to your gun holster's right hand!", "或者，右鍵來將它裝備至你的槍套右手！" },
            { "Can be in both hands at the same time!", "可以同時存在於槍套的左右手！" },
            { "(A) Great Damage scaling for explosions!", "（A）很高的爆炸傷害修正！" },
            { "(Special) The farther your cursor is, the faster the axe goes!", "特殊：你的鼠標離你越遠，斧子速度越快！" },
            { "(D) Low Damage scaling for Explosions on hit", "（D）低的爆炸傷害修正" },
            { "Jerry does not like being called names", "傑瑞可不喜歡被別人起外號" },
            { "(D) Really low scaling damage", "（D）很低的傷害修正" },
            { "(D) Low Damage scaling for flames", "（D）低的火焰傷害修正" },
            { "(B) Great spread on with flames", "（B）範圍寬廣的火焰" },
            { "Red - No Effect", "紅——樸實無華" },
            { "Orange - Explodes", "橙——焰華綻放" },
            { "Yellow - Teleports after hitting an enemy", "黃——閃轉騰挪" },
            { "Green - High damage", "綠——會心一擊" },
            { "Cyan - Causes several debuffs", "青——鉆心剜骨" },
            { "Blue - Homing", "藍——奪命追魂" },
            { "Purple - Summons powerful blades upon hitting an enemy", "紫——萬劍穿心" },
            { "(B) Very good throwing weapon that sticks around!", "（B）非常棒的投擲物，而且會持續存在好一陣子！" },
            { "Orb Weapon Type", "武器類型：球體" },
            { "Juggler Weapon Type", "武器類型：拋接" },
            { "Creates flamed explosions for some explosion dusts!", "讓某些魔法塵在引燃時產生火焰爆炸！" },
            { "These do not stack!", "和其他魔法塵增效器的效果不能疊加！" },
            { "Use this to put inside of your Xixian flask and when you drink it, the effects of this insource is used!", "召喚我以灌滿希克斯瓶，當你飲用它希克斯瓶時，我的效果就會被觸發！" },
            { "She'll just love you forever I guess.", "那，就讓她永遠愛著你吧" },
            { "Put one on as an accessory, eat for temporary effects!", "既可以作為飾品佩戴，也可以吃下去以獲得臨時效果！" },
            { "(C) Medium Damage Scaling (Fireballs) On Hit!", "（C）擊中時產生中等傷害修正的火球" },
            { "Creates a very good voidal explosion on dust explosions and constants!", "魔法塵引爆時釋放強力的虛空爆炸！" },
            { "Use an insource to put something in the flask, then drink it! It acts like an infinite potion!", "先召喚瓶內容物以灌滿我，然後左鍵將我一飲而下！就像一瓶無限使用的藥水！" },
            { "(B) Good Damage Scaling (Alcarish Blobs) On Hit!", "（B）擊中時產生不錯傷害修正的混溶塊" },
            { "(C) Medium Damage Scaling (Stingers) On Hit!", "（C）擊中時產生中等傷害修正的毒刺" },
            { "(B) Medium Damage Scaling (Grail shot) On Hit!", "（B）擊中時產生中等傷害修正的礫金" },
            { "(C) Medium Damage Scaling (spikyballs) On Hit!", "（C）擊中時產生中等傷害修正的刺球" },
        };
        ForceLocalizeSystem.LocalizeDerivedByType(typeof(ModItem), nameof(ModItem.ModifyTooltips), localizations);
        ForceLocalizeSystem.LocalizeByType(typeof(ClassSwapItem), nameof(ModItem.ModifyTooltips), new() {
            { "Can be changed to", "可使用寶珠轉換為" },
            { "Damage Type Swapped!", "武器職業已被改變！" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.GlobalItemEdits", nameof(ModItem.ModifyTooltips), new() {
            { "Lunar Veil: 8% decreased ranged damage", "【穹月天紗】減少8%遠程傷害" },
            { "Lunar Veil: Stealth is MUCH less effective", "【穹月天紗】潛行的收益大大降低" },
            { "Lunar Veil: 6% decreased ranged damage", "【穹月天紗】減少6%遠程傷害" },
            { "Lunar Veil: 6% decreased ranged critical strike chance", "【穹月天紗】減少6%遠程暴擊率" },
            { "Lunar Veil: 4% decreased ranged damage", "【穹月天紗】減少4%遠程傷害" },
            { "Lunar Veil: Damage boosters are 50% less effective", "【穹月天紗】所有傷害增幅效果減少50%" },
        });

        // 應該是測試用物品
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Test.HavocSignaler", nameof(ModItem.ModifyTooltips), new() {
            { "Use this item to signal Havoc for an attack\nRight click to swap attacks", "使用此物品來控製浩劫龍械的攻擊，右鍵切換攻擊模式" },
            { "Attack: Charge", "攻擊模式：沖撞" },
            { "Attack: Mini Laser", "攻擊模式：小型激光" },
            { "Attack: Big Laser", "攻擊模式：大型激光" },
        });
        if (AlwaysFalse())
        {
            // 這一段不會被執行, 只是展示另外一種方式
            // 這種方式更加精準, 但會費力一些
            ForceLocalizeSystem.LocalizeByTypeName(nameof(AmberBroochA), nameof(ModItem.ModifyTooltips), new() {
                    { "Simple Brooch!", "簡易飾符!" },
                });
            ForceLocalizeSystem.LocalizeByTypeName(nameof(AmethystBroochA), nameof(ModItem.ModifyTooltips), new() {
                    { "Simple Brooch!", "簡易飾符!" },
                });
            // 如果不需要特定翻譯的話使用整個 localizations 字典也沒問題
            ForceLocalizeSystem.LocalizeByTypeName("LittleWand", nameof(ModItem.ModifyTooltips), localizations);
            ForceLocalizeSystem.LocalizeByTypeName(nameof(BonedThrowBroochA), nameof(ModItem.ModifyTooltips), localizations);
            // ...
        }
    }
    static bool AlwaysFalse() => false;
}
//風卷殘雲! 刮骨療毒! 大刀闊斧! 滌蕩舊弊!
