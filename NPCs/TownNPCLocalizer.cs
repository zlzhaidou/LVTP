using Stellamod.NPCs.Bosses.Ereshkigal;
using Stellamod.NPCs.Bosses.Zui;
using Stellamod.NPCs.Bosses.Zui.Projectiles;
using Stellamod.NPCs.Town;

namespace LVTC.NPCs;
public class TownNPCLocalizer : ModSystem
{
    public override void Load()
    {
        #region Aimacra 安魅凱拉
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetBestiary), new() {
            { "Aimacra??? From Diari?? Crazy", "安魅凱拉？？？從Diari來的？？好瘋狂噢！" },
            { "Aimacra", "安魅凱拉" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.GetChat), new() {
            { "They also have fox ears like me lmao", "她也像我一樣擁有狐貍的耳朵啊（憋笑）" },
            { "This world seems a bit off don't you think?", "你是否也覺得這個世界有點不對勁呢？" },
            { "I'm not one to brag but this place is so much better than Ekrose", "我不是喜歡誇誇其談的人，但這個地方確實比艾科洛斯好多了。" },
            { "Did Sirestias ask me to find her again?", "希絲忒莉亞又叫我去找她了嗎？" },
            { "Yeah I've been traveling while you were out.", "遇到你之前我一直在遊蕩" },
            { "Go play Diari on steam? I have no idea what that means", "要不要試著steam下載個Diari玩玩？等等，我在說什麽" },
            { "Do people think I'm not into pans?", "是不是大家都認為我不喜歡平底鍋呢？" },
            { "Sooo can we forget about everything that happened in Ekrose?", "我們可以忘記在艾科洛斯發生的一切嗎？" },
            { "I am really sorry for what we went through but now were here you know?", "我真的很抱歉我們曾經所經歷的一切，但是現在我們在這裏應該有個新的開始，不是嗎？" },
            { "Sirestias went out again, and this time I'm not finding her.", "希絲忒莉亞又出去了，這次我可不會再去找她了" },
            { "Hey could you go do something, I'm about to get dressed, but honestly I say that like you haven't seen me before.", "嘿，我要換衣服，你能去做點別的事情嗎？但說實在的，你以前又不是沒見過我換衣服." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Aimacra), nameof(Aimacra.SetNPCNameList), new() {
            // 安魅凱拉有三個名字,  一個是 Aimacra, 一個是 Aimacra, 一個還是 Aimacra
            { "Aimacra", "Aimacra" },
            { "Aimacra", "Aimacra" },
            { "Aimacra", "Aimacra" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetChatButtons), new() {
            { "Talk", "閑聊" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.OnChatButtonClicked), new() {
            { "Heyyy at least we're out of Ekrose alive! I'm glad Vixyl is safe back at the main house.", "唉，至少我們活著離開了艾科洛斯，維西爾也安全回到家鄉，這已經是很好的結果了" },
            { "I hate being Sirestias's Assassin.. Speaking of I met a guy named Veldris and he's totally cool!", "我不喜歡當希絲忒莉亞的殺手，emmmmm，說到這個，我今天遇到了一個叫威狄爾斯的家夥，他超酷的好吧" },
            { "I'll be back I may go to look for some new stuff underground. ", "我會回來的，我可能會去地下尋找一些新東西" },
            { "What is a thug shaker? To shake or not to shake? Sometimes I wonder if life truly does give lemons.", "什麽才算是一個狂熱搖滾者呢?隨音樂搖擺還是不隨音樂搖擺，這是一個問題...唉，有時候我感覺生活真是苦澀啊" },
            { "What class would I even be? ", "我在這裏算什麽職業呢...?" },
            { "Hey sorry for what may of happened on Ekrose but I hope we can still be friends and make up to each other.", "對於在艾科洛斯發生的事情，我深感抱歉，我們還可以繼續作患難與共的朋友嗎?" },
            { "STARBOMBERS ARE ON THIS PLANET TOOOOO!!!", "這裏怎麽也有星爆者啊！！！" },
            { "I totally haven't been playing geometry dash.", "我今天沒有摸魚玩幾何沖刺，快誇我(•ω•`)" },
            { "I've seen some weird things in my life, but never would I have thought Fenix would be more chronically horny than Sirestias, but to be fair Sirestias just gets more power doing that.", "我短暫的一生中，我見識過各種各樣事物，但我真沒想到會有人比希絲忒莉亞還要欲望高漲——指緋琦.那可是希絲忒莉亞的力量來源啊！" },
            { "I hate being part human.", "在對於自己有一半人類的血統這件事情上，我非常討厭" },
        });
        #endregion
        #region Bordoc 波爾杜克
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetBestiary), new() {
            { "Steaming from the depths", "燃燒，冒煙" },
            { "Bordoc the eternal blacksmith", "鐵匠波爾杜克" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.GetChat), new() {
            { "Shes got some great cogs", "她的零件不錯" },
            { "BRMMMM", "喀 喀" },
            { "Everyone always uses me but never asked how I'm able to talk.. ", "所有認識我的人中，沒人問過我是怎麽說話的..." },
            { "I don't care I need to gamble", "我對賭博不屑一顧" },
            { "My armors are the best in the lands", "我打造的盔甲無可匹敵！" },
            { "Sirestias and Aimacra game by recently and they laughed at me because they thought my shop was useless", "希絲忒莉亞和安魅凱拉最近過來轉了一圈，她們居然敢嘲笑我的工藝！" },
            { "Im always feeling hot!", "我炎熱無比！" },
            { "Heh, nobody is as good as me", "我的技巧天下無雙！" },
            { "Burning Burning, heat and heat", "燃燒，燃燒，熱量，熱量！" },
            { "I'm inpenetrable", "我堅固無比！" },
            { "Damn we have some hot shit here", "這裏有點熱啊" },
            { "Only I know that Gothivia has so many barriers between her and the rest of the world, nobody will be able to kill her.", "我只知道，歌瑟梵在她與世界之間設下了重重阻礙，沒人能找到她." },
            { "Those idiot gintze have made a horrible decision, now they can't use my armors I made for them.", "那些玄鐵蠢貨們真是不識時務，現在他們用不了我造的盔甲了." },
            { "KRMMMKTEYYYMMMM BRMMMMM", "咯咯咯咯 嗡嗡嗡 咯吱咯吱" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Bordoc), nameof(Bordoc.SetNPCNameList), new() {
            { "Blacksmith BORDOC", "鐵匠波爾杜克" },
            { "Blacksmith BORDOC", "鐵匠波爾杜克" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetChatButtons), new() {
            { "Heart of the Morrow", "幽曦之心" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.OnChatButtonClicked), new() {
            { "I want you to prove to me you're ready to obtain this, I've given you a broken core, if you restore its power, it's all yours. Show me your determination to be Gothivia's doll! You won't be the first to fail.. And maybe she'll come to thank you one day. ", "向我證明你值得擁有它：這是一個破損的核心，如果你能修復它，它就歸你了.你對歌瑟梵的忠誠能夠支持你走出這一步嗎？如果你失敗了,你可不是第一個.如果你成功了，她會由衷感謝你的." },
        });
        #endregion
        #region BoundGia 受縛的吉婭
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.OnKill), new() {
            { "Im being taken away help!", "我被抓走了！救命！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.SetBestiary), new() {
            { "A bound scientist lurking in the Virulent", "瘴煞之地的一名被綁架的科學家" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.GetChat), new() {
            { "Oh goodness thank you for saving me. I dont know how long I was tied up... I got stranded down here by a bunch of scouts I presume are from the morrow. I really caused a mess this time but I am really glad you saved me. D'you have a place to stay?", "天哪，太謝謝你幫我松綁了！我都記不清我在這裏呆了多久...一群應該是幽曦那裏的斥候把我扔到這就走了.正當我要放棄的時候你就把我救了！你有能住的地方嗎？" },
        });
        #endregion
        #region CellConverter 分子轉換器
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetBestiary), new() {
            { "Burning in a magical laboratory", "在一個古老的魔法工廠裏仍然運轉著" },
            { "The Cell converter", "分子轉換器" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.GetChat), new() {
            { "KRTTCAVSJKSC", "咯咯 噠噠 吱 喀" },
            { "I WANT SCRAP", "我 要 廢料" },
            { "MAKE YOUR SCRAP TOKENS FOR TRADE. KRM", "請 做 一些 廢料 來 交換. 喀." },
            { "YEEERRRM", "嗚嗚嗚 轟" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetNPCNameList), new() {
            { "Cell Converter", "分子轉換器" },
            { "Cell Converter", "分子轉換器" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetChatButtons), new() {
            { "Put in scrap token", "放入廢料" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.OnChatButtonClicked), new() {
            { "Weapon Converted!", "武器 類型 已 轉化 完成" },
            { "KRRRT, Sensors say you have inputed a token, here you go per request.", "咯咯， 傳感器 檢測 到 廢料， 給 你 東西" },
            { "Womp womp, looks like nothing for you!", "嗚 嗚， 沒有 東西 給 你" },
            { "Error, try again.", "出現 錯誤， 請 再次 嘗試" },
            { "Put in another token.", "請 繼續 放入 廢料" },
        });
        #endregion
        #region Delgrim 戴爾格林
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetBestiary), new() {
            { "A magical engineer huh?", "魔法，工匠？有趣..." },
            { "Delgrim the eternal engineer.", "永世工匠戴爾格林" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.GetChat), new() {
            { "You're chill aren't ya?", "你很冷靜，不是嗎？" },
            { "Everyone comes in for the same stuff, come and go please.", "每個人都為了鍛造相關事情來到和離開這裏，想必你也一樣吧" },
            { "Another visitor?", "啊,又一位訪客？" },
            { "What goes on in the world nowadays?", "現在世界形勢如何？" },
            { "I don't mean trouble, but do as you please.", "我不想惹麻煩，但你也不必過於拘謹." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Magical Engineer Delgrim", "魔法工匠戴爾格林" },
            { "Magical Engineer Delgrim", "魔法工匠戴爾格林" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetChatButtons), new() {
            { "Old Tales", "聽他講些往事" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.OnChatButtonClicked), new() {
            { "An old time there was a thriving capital, we used to call it the Harboring Morrow. It was a thriving city under the protection of Gothivia, Verlia, and Irradia. I used to be a member. Gothivia loved every one of us, Verlia would be off directing armies and Irradia well she spent time making electronics. ", "很久很久以前，有一個繁榮的都城，我們過去稱之為「幽曦城堡」。這是一座在歌瑟梵、薇莉亞和伊瑞蒂安保護下繁榮的城市。我曾經是其中的一員。歌瑟梵愛著我們每一個人，薇莉亞會指揮軍隊，而伊瑞蒂安則喜歡研究機械。" },
            { "Irradia would make amazing tech, and I would come to every show she would host and watch her mechanic sword fights and spare parts, Verlia would sometimes participate and tear all of them apart. Verlia was just too good of a swordsman.", "伊瑞蒂安總會製造出令人驚嘆的發明，我會去參加她主持的每一場演示，觀看她的機械劍的戰鬥與戰備演示。薇莉亞有時也會參與進來，將伊瑞蒂安的發明全部擊敗。不得不說，薇莉亞是一名很厲害的劍客。" },
            { "Gothivia would always come down at 10 A.M in the morning to greet all the city members, it used to be the time of my life. She'd give us goodies and Rek would come by with his binding light to empower the underground and brighten things up. ", "歌瑟梵總會在早上10點降臨，對城市所有成員進行問候，並給我們帶來甜點，那曾是我生命中最快樂的時光。此外，萊克會給我們帶來陽光，照亮地下的一切。" },
            { "Verlia and Gothivia are sisters, although they don't look it anymore, they used to be twins yet they couldn't be different from each other. Verlia was always rambunctious and outgoing while Gothivia was a calm and loving soul, the two got along.", "雖然薇莉亞和歌瑟梵看起來並不像，而且性格也截然不同，但實際上她們兩個是雙胞胎姐妹。薇莉亞總是活潑好動，歌瑟梵靜雅且富有愛心，兩人相處得十分融洽" },
            { "Of all the inventions Irradia made, by far my favorite was a rendition of Gothivia's Rek called Havoc. It was a magnificent beast. It held it's own against Verlia in the shows, if only I could go back to those days. ", "在伊瑞蒂安製造的所有發明中，我最喜歡的是模仿歌瑟梵的萊克製作的「浩劫龍械」。它是一頭壯麗的巨獸。在演示中，它甚至能夠與薇莉亞抗衡，要是能回到過去的那些時光該多好啊。" },
            { "Verlia always would be training the army, the gintze army wasn't exactly the most reliable mainly because of Verlia's idiocity and lack of care for danger. The army would always charge head first without a care for defense. I wonder where the army was when we were defending against the Carian warriors and knights", "因為薇莉亞那個笨蛋對危機意識的缺失，導致薇莉亞訓練的玄鐵軍隊實際上是並不可靠的。那支軍隊總是從不防禦，只管沖鋒在前。我在想，當我們在抵禦卡利亞戰士和騎士的時候，這支軍隊在哪兒呢？" },
            { "Some days I look back on the Harboring Morrow and wonder why we fell so hard. I remember BORDOC, an excellent blacksmith but too arrogant to read his ways. Irradia taught me some amazing things I carry with me today and all the people. the people.. ", "有時候，我不自矜會回憶起在「幽曦城堡」的時光，思考我們為何會如此徹底地衰落。我記得有一個名為波爾杜克的鐵匠，他技藝高超，但他又過於自負不願改變自己的生活方式。伊瑞蒂安教給了我一些令我至今受益匪淺的驚人之事，還有所有的人們……那些人們……" },
            { "You know, I had loved Irradia, until we seperated through war our connection was magically I would say. Damn witches and their artistry. I don't hate magic, but its the reason I lost so much. That commander, I will never forget the smirk on that face. So called Fenix and her army of Carian knights. ", "我曾經深愛著伊瑞蒂安，直到戰爭將我們分離，我們之間的緣分非常奇妙。魔女和魔法組合技真是令人頭疼。我雖然不討厭魔法，但魔法卻是導致我和伊瑞蒂安分離的原因。我永遠不會忘記作為指揮官的鳳涅克斯以及她那些卡利亞騎士的軍隊臉上的戰勝後的得意。" },
            { "One day in the Harboring Morrow, the most joyous of days, some collectors came back infected by some strange disease, as you may know now it's called the Virulent. An acid like corruption that eats at the soul. It tore our village apart like the black plague. It weakened us, right before a Carian army swept us away at our worst, we stood no chance.", "那本該是充滿歡樂的一天，但那一天一些外出旅行的人感染了被後世稱為「瘴煞」的瘟疫回到了幽曦城堡。這種瘟疫像酸液一樣侵蝕著我們的靈魂，它像黑死病一樣襲擊了我們的村莊。它大幅度削弱了我們的力量，然後卡利亞軍隊在危機時刻趁虛而入，以至於我們完全沒有獲勝的希望。" },
            { "Verlia one day left the Morrow to search and make peace with the witches in the upcoming villages, she was by far the most magical out of the three of them, so she would stand a chance to help, when she came back, she was out of her mind.", "薇莉婭有一天離開了幽曦之地，去附近村莊尋找與魔女們和平相處的辦法。她是她們三個中最有魔法天賦的，所以她也是最有機會能夠找到破局之法的人。但是當她回來時，她已經陷入了瘋狂。" },
            { "When Verlia came back from her excursion, she well, gave information that changed the course of our lives. Me being in a relationship with Irradia I was able to be let in on that information. She shared to us a tome from a small witch village. This would a fatal mistake.", "當薇莉婭從她的旅途歸來時，她提供了一些改變了我們生活方式的辦法與建議。由於我和伊拉迪亞的關系，使得我也了解到那些辦法與建議。薇莉婭和我們分享了一本來自一個魔女村莊的卷軸，但這也將是一切災難的起點。" },
            { "Verlia's excursion took place right when the corruption started occuring, she went to look for a way to heal the damaged. Gothivia would do her best to heal everyone but she was only one person in the biggest capital in terraria. ", "在瘟疫出現後，薇莉婭就出發去尋找治愈瘟疫的方法了。而歌瑟梵則盡她最大的努力去治療每一個人，但她只有一個人，能盡的力量太有限了。" },
            { "One harrowing day, a fox appears at the doorstep of Verlia and Gothivia's abode. I knew my eyes decieved me when I had seen the fox transform into a tall Nero, they are like human cats but I thought they'd been extinct for millenia! ", "在一個月黑風高的晚上，一只狐貍出現在薇莉婭和歌瑟梵的住宅門前。當我看到那只狐貍變成了一個高大的人形生物時，我才意識到她並不是狐貍，她是獸人！！！在遇到她之前，我以為她們種族已經滅絕了幾千年了" },
            { "When a fox arrived on the doorsteps of our beloved, The fox lady brings out what I can only think was a lantern and all I could make out inside that room was a giant blue flash and the screams of Gothivia. This was the last time anyone heard of Verlia.", "當一位狐貍女士來到我心愛之人門前時，她拿出了一個我認為是燈籠的東西。然後一道巨大的藍色閃光伴隨著歌瑟梵的尖叫從屋內傳出。然後薇莉婭就消失了。" },
            { "After what I call the 'blue flash,' everyone hurried to a sign of screaming in the middle of the night. We all come to see Gothivia crying with a note in her hand and the fox lady. She introduced herself as Fenix. ", "「藍色閃光」後，很多人急忙跑到尖叫發出的地方。但是我們只看到了手裏拿著一張紙條哭泣的歌瑟梵，以及一位自稱緋琦的狐貍女士。" },
            { "Fenix was a tall statured woman yet extremely menacing, at times a lot of us thought she may have been more powerful than Gothivia, but deep down Gothivia's suppressed feelings for her family would probably overcome that. ", "緋琦是一位身材高大、看起來極其強大的女性，甚至我們中的很多人認為她比歌瑟梵更強大。但是大家又認為失去家人、在悲痛爆發的歌瑟梵力量會更強大。" },
            { "The illnesses started to rack up and since Verlia disappeared, our Harboring Morrow was not complete, there was nobody to keep our armies in check, Gothivia wasn't mentally there anymore and Irradia was trying her best to get everyone to calm down. It was a horrible time.", "自從薇莉婭消失後，瘟疫快速蔓延，「幽曦城堡」已經名存實亡，沒人維持軍隊秩序，歌瑟梵深受打擊一蹶不振，伊瑞蒂安則在盡力安撫著所有人。那真是一段可怕的歲月。" },
            { "Irradia did explain what happened to Verlia, but I thought it was just downright evil. Fenix trapped Verlia's soul inside a lantern and bounded it to a secret power for experimentation because she stole a book from their village. We'll never get to see her again will we?", "伊瑞蒂安向我解釋了在薇莉婭身上發生了什麽。因為薇莉婭從緋琦的村莊偷了一本書，緋琦將薇莉婭的靈魂困在燈籠裏，並用秘密力量上在她身上進行實驗，緋琦真是太邪惡了。我們或許再也見不到她了，對吧？" },
            { "I think Irradia's way of coping to the loss of Verlia was teaching me now that Im starting to recollect. She may have used it as a way of reflecting, and I didn't see that she was hurting yet I was always there for her.", "我曾經認為伊瑞蒂安教導我是為了沖淡失去薇莉婭的悲傷。但是我現在反應過來，她可能用這種方式來思念薇莉婭，雖然我當時沒有意識到她的情緒，但我始終陪在她身邊。" },
            { "I kept on living, hell I even got sick from the Virulent, yet I was Gothivia's last person to get healed from her. Rek eventually got infected too yet since havoc was electronic, he stayed normal. The creatures that lived the best were mostly metallic, its what remains of our old village.", "時間匆匆，不曾停留，我甚至也曾感染「瘴煞」，但最後歌瑟梵治愈了我。就算是雷克，最終也沒有逃過被感染的命運，但由於浩劫龍械是機械的，它不會被感染。在我們古老村莊的遺跡中，生活得好的大多是金屬生物。" },
            { "After the last healing in from Gothivia, I'd say about 90% of our village was wiped out from the Virulent, our soliders, our love, and will to live all started to fall apart. ", "雖然最後瘟疫被歌瑟梵治愈了，但是我們村莊大約有90%的人被「瘴煞」瘟疫奪去了生命。瘟疫之後，我們的軍隊、對生活的熱愛、和生活的意誌都開始慢慢瓦解。" },
            { "I could recall me laying on a bed as I watched our city crumble, Irradia would stay by my side and we'd comfort each other as the world caved in for us.", "我現在還記得當時自己躺在床上，伊瑞蒂安就陪在我身邊，我們一起看著我們的城市一點點走向破敗，一起互相安慰。" },
            { "After a while of our suffering in the city Gothivia would leave to seek vengence and power to save her sister, leaving Irradia to be at the helm. Take a guess who arrived not so soon afterwards? Fenix, she came to take what was left of us.", "在我們城市遭受瘟疫一段時間後，歌赫梵離開了城市去追尋力量來拯救薇莉亞與復仇，留下了伊瑞蒂安來管理整個城市。你猜猜誰不久之後誰來了？是鳳涅克緋琦這個惡魔！她來摧毀了我們剩下的一切。" },
            { "Fenix is like a scouraging raven looking for its next feast, and we were on the menu. I was forced to split from my love due to her sacrifices of being a leader. We haven't seen each other since, yet I know she's out there somewhere. No way would she loose to Fenix..", "緋琦就像一只獵食的禿鷲，而我們則是她的食物。伊瑞蒂安踐行了作為領袖的責任，她犧牲自己吸引緋琦，我被迫與她分開。從那以後我再也沒有見過她，但我知道我在某處一定能找到她。她是絕不會輸給緋琦的..." },
            { "The Great Departure, that's what I call the leaving from what was left in our city. As the Carian army approached, we hid through underground tunnels to escape, some of us, including me, haven't gone back to the surface. I was even invited to come to the Fable.", "「大遷徙」，這就是我對逃離我們城市進行遠行的稱呼。隨著卡利亞軍隊的逼近，我們通過地下隧道躲避，包括我在內的一些人，再也沒有回到地面。我甚至被邀請過前往「古諭遺境」。" },
            { "Those who made it to the surface from the Great Departure reinvented the Harboring Morrow yet from all the messages from BORDOC, it isn't the same. They close their doors to everyone in fear and they look for Gothivia, she never said where she went.", "那些在「大遷徙」中成功到達地面的人重建了「幽曦城堡」，但從波爾杜克的消息來看，「幽曦城堡」已經不再是原來的「幽曦城堡」了。居民出於恐懼對所有人關閉了城門，並且他們在尋找歌赫梵，但是歌赫梵從未說過她去了哪裏，因此尋找起來猶如大海撈針。" },
            { "I was in tunnels underground for 10 of my years, now I lay here with all the corpses and electronics that I bear, I've travelled every part of this world except the surface, to ever find Fenix again would send me over my limit.", "我在地下隧道裏待了10年，現在我和我所攜帶的所有物品與電子設備都在這裏。為了尋找伊瑞蒂安，我走遍了這個世界除地面的每個角落。我現在已經力不從心了，如果再次遇到緋琦，我就只能接受天命引頸受戮了吧" },
            { "You know, maybe I should have travelled with the rest of the members of the morrow, many of us split up in our escape, many died, hell, maybe I'm the only standing survivor, but I'm here.", "你知道嗎，或許我應該和幽曦城堡的其他成員一起逃亡，在我們逃跑時很多人分開了，很多人死了，見鬼，我或許是唯一的幸存者，但我卻在這裏獨自茍活。" },
            { "My creations that I make now are from my explorations, I will find Irradia again, I need to apologize, to say something. These are all for her anyway. If only I could have stopped this from getting this way, maybe I could have stayed against her will.", "我現在創作的作品都來自於我的探索，我會再次找到伊瑞蒂安，我會說些什麽向她道歉。如果我當初能阻止這一切發生，我會不顧她的意願留下來。" },
            { "Of all my years to live and ever to live, I will never understand things like Fenix, her torturous additude, why she went to such lengths to kill us, why the infection was so hard to fend off, and why I couldn't stay, these are all for you, Irradia. ", "在我過去和未來的所有年歲裏，我永遠無法理解像緋琦這樣的人。她折磨人的態度，她為什麽要費盡心思殺死我們，為什麽瘟疫如此難以抵擋，以及為什麽我不能留下來，這些都是為了你，伊瑞蒂安。" },
        });
        #endregion
        #region Gambit 賭徒
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetBestiary), new() {
            { "She loves those ruin medals huh?, so much so that she is now attracted to you :(", "她太喜歡那些遺跡勛章了！以至於她已經對你生出了感情 :(" },
            { "Zielie the Gambit", "賭徒澤麗" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.GetChat), new() {
            { "I love the party girl! Shes really sweet! Umm could you maybe hook us up :(", "我太喜歡派對女孩啦！她又善良又有趣！你覺得你能不能...給我們互相介紹一下？" },
            { "Hii, it is a me, Zielie! I'm frantic at moments but what can you expect when your in a world full of death and loooove?", "嗨~，我叫澤麗！我有時會有點神經質，但在一個充滿愛與死亡的世界中這樣不是最好了嗎！！" },
            { "Ive heard that the morrow is very pretty, I talked to veribloom and she said her society is falling apart though so maybe not.", "聽說幽曦之地很漂亮，但我問薇綠的時候她說那裏的社會已經快要完全失控了，我還是先不去那裏了為妙." },
            { "I have some things on the market for you, I go around collecting items and I get more stuff when you beat bosses and honestly, you seem really cool! :0", "我這裏有點好東西賣給你！都是我自己撿來的和你打Boss剩下的東西~你也很棒喲！" },
            { "You know who is responsible for your dice rolling righttt? You know, uh after you beat bosses? Yeah, thats me ya silly lovebug", "哎，你知道你的賭博骰子都是誰在扔對吧？就是我呀你個小傻瓜." },
            { "Can we get married?", "咱們來結個婚，你意下如何？" },
            { "Soo are we gonna get married or are you gonna buy something?", "買點東西吧！難不成~你想把自己賣給我？" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Zielie", "Zielie" },
            { "Zemmie", "Zemmie" },
            { "Zeilie", "Zielie" },
            { "Zielie", "Zielie" },
            { "Wenomechinimasama", "Wenomechinimasama" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetChatButtons), new() {
            { "Marry", "求婚！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.OnChatButtonClicked), new() {
            { "OMG YOU DOOOO? Aww youre so sweet \nwe can hold off until a bit later :3", "天哪你答應了？？？！！！當然啦甜心~\n但我們還是可以再等一會的吧:3" },
            { "Aww cmon, don't be so silly, \nlets wait until we fix this world, \nlet me help you out :P", "小傻瓜~\n等這個世界的問題解決了再說吧.\n讓我來幫幫你！" },
            { "Awaaaaaaaaaaaaaaaaaaaaaaaa~ \n(Zielie is too flustered to continue)", "哇啊啊啊啊啊啊啊啊啊啊~\n（澤麗激動到語無倫次）" },
        });
        #endregion
        #region Gia 吉婭
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetBestiary), new() {
            { "Wow you done messed up this time with the Virulent spill huh.", "看看這瘴煞的勢頭，你這次可真惹上大麻煩了." },
            { "Gia the Scientist", "研究員吉婭" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "她有那麽多超棒的機械！我好想要啊." },
            { "A long time ago, I used to experiment with Biotech. It went wrong, and teleported pieces of itself all over the world. You might have found some by now.", "很久之前我還在研究生物科技，但是那件作品出了岔子，殘片飛散到了世界各處.你可能已經找到了其中的幾片." },
            { "Maybe if you find some of my lost tech, you could craft my original biotech and retry my experiments!", "如果你能找到那些我遺失的科技零件，就能造出我的獨創機器，重試我的試驗！" },
            { "The guide seems to know too much for a human being. I feel like he has something else connected to him…", "向導知道的實在太多了，他真的只是個人類嗎？我感覺有什麽其它東西與他有聯系..." },
            { "The merchant keeps telling me about this dangerous eye thing. I could just zap it with my Bio laser.", "商人一直在說什麽危險的大眼球...它要是敢來，我就讓它嘗嘗我的反生物激光." },
            { "Aimacra seems pretty neat, too bad she's taken", "安魅凱拉看起來不錯，可惜她已經有伴了." },
            { "I wouldn't mind hooking up with the Steampunker :)", "蒸汽朋克人也不賴嘛，我想和她試試：）" },
            { "So many spare parts and materials, bring them all to me!", "有多少零件材料就給我拿來多少！" },
            { "I can't believe I let it get loose, I've complicated too many things.", "真不敢相信我居然一時疏忽把「它」放出來了...這下事情復雜了好多." },
            { "Can you go collect some runes for me? I'd love for you to get working.", "給我收集一些符文碎片吧！反正你閑著也是閑著." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.SetNPCNameList), new() {
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetChatButtons), new() {
            { "Trade Rune", "交付符文" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.OnChatButtonClicked), new() {
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" }, // 勿動, 下同
            { "I give you my thanks for this Desert artifact, it'll help further my reserch to fixing this mess!", "感謝你幫我找到了這塊符文.這對我彌補這爛攤子的研究很有幫助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感謝你幫我找到了這塊符文.這對我彌補這爛攤子的研究很有幫助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },

            // 這裏應該是 Ice artifact, 但是笨笨作者復製粘貼時忘改了, 導致只能使用 InOrder 的方式改
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感謝你幫我找到了這塊符文.這對我彌補這爛攤子的研究很有幫助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Overworld artifact, it'll help further my reserch to fixing this mess!", "感謝你幫我找到了這塊符文.這對我彌補這爛攤子的研究很有幫助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Ocean artifact, I'll research it greatly, heres something in return..", "感謝你幫我找到了這塊符文，我會仔細研究它的.這是些回禮，難表謝意..." },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Jungle artifact, it'll help further my reserch to fixing this mess!", "感謝你幫我找到了這塊符文.這對我彌補這爛攤子的研究很有幫助！" },
        });
        #endregion
        #region Ginztel 玄鐵軍官
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.SetBestiary), new() {
            { "Dumbfounded by your strength, the commander retired and came to your base for a visit and a free hotel.", "這名已退休的玄鐵軍官被你的力量大為震驚，他決定來看看...以及蹭個住處." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ginztel), nameof(Ginztel.SetNPCNameList), new() {
            { "Gintzia", "Gintzia" },
            { "Ginztel", "Ginztel" },
            { "Steven Universe", "Steven Universe" },
            { "Gintzel", "Gintzel" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.GetChat), new() {
            { "Hehe the Demonilitionist guy is pretty cool, he's got bombs..", "嘿嘿，那個爆破專家不錯，他有好多炸彈..." },
            { "Im just peeping around, I might stay for a while..", "俺只是來看看...或者在這住一小會." },
            { "My team was quite weak to say, I apologize for the inconvience", "俺的那幫人好弱啊.真是給你添麻煩了." },
            { "Some of the things I'm selling are from base, we've all taken quite a liking to you all.", "俺賣的東西好多都是是從俺們基地拿來的！俺們都覺得你還是個不錯的家夥！" },
            { "If you can kill Gothivia for us we can scavange and steal their items, please help us do that", "如果歌瑟梵掛了俺們就能搶她的東西啦！你一定要贏啊！" },
            { "We may be weak but we still give all of our little praise to Verlia, hence why we stole from her sister..", "俺們不強，但俺們最稀罕薇莉婭，才敢偷她姐姐的東西." },
            { "Could you murder Gothivia in the most brutal fashion possible? She is way too dauntless and carefree, we hate her and she took our home..", "你一定要把歌瑟梵狠狠的揍一頓呀！俺們看著她那副目中無人的表情就來氣！她還霸占了俺們的家..." },
        });
        #endregion
        #region Ishtar 狂淵
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ishtar), nameof(Ishtar.SetBestiary), new() {
            { "Entrance", "狂淵入口" },
            { "The entrance to the Ishtar Citadel", "狂淵的入口" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ishtar), nameof(Ishtar.SetNPCNameList), new() {
            { "Ishtar Pin location", "狂淵" },
            { "Ishtar Pin location", "狂淵" },
        });
        #endregion
        #region Mardenth 瑪登斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetBestiary), new() {
            { "One of the 3 Children of Daeden, this one being the most useless", "達登的三個孩子裏面，最弱小的一個" },
            { "Mardenth of the Veil", "天紗之瑪登斯" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "她有那麽多酷炫的裝置，我喜歡它們！" },
            { "Damn that Sigfried guy.", "那個叫齊格飛的家夥真是該死啊" },
            { "Where's Ereshkigal?", "厄莉什基迦勒在哪" },
            { "Daedus, Jovhia, Daeden? Where'd you all go?", "代達斯，喬維亞, 達登?你們都去哪裏了？" },
            { "I'm quite formiddable you see. I can destroy anything with my hands.", "你瞧，我相當可怕。我可以用我的雙手摧毀一切。" },
            { "I need to study up on my electric magic. If my dad wasn't dead he'd be proud of me. Gosh I wish you were here Daeden", "我需要進一步學習我的電系魔法。如果我父親還活著，他一定會為我感到驕傲的。天哪，我真希望你能在這裏，達登" },
            { "I never knew my mom..", "我從沒見過我的母親..." },
            { "Why is Jovhia always in the sky?", "為什麽喬維亞總是在天上呢？" },
            { "Hey you, get out of here!", "嘿，你，滾出去！" },
            { "Scadabble you women harrasser.", "你這個騷擾女性的家夥！" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Mardenth), nameof(Mardenth.SetNPCNameList), new() {
            { "Mardenth", "瑪登斯" },
            { "Mardenth", "瑪登斯" },
            { "Mardenth", "瑪登斯" },
            { "Mardenth", "瑪登斯" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetChatButtons), new() {
            { "Talk", "閑聊" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.OnChatButtonClicked), new() {
            { "Heheheh, I like to eat little wormy guys but they won't stop squiggling. Reminds me of when our dad Daeden left us. ", "呵呵呵，我喜歡吃那些小蟲子，但它們總是不停地扭動。這讓我想起了我們父親達登離開我們的時候。" },
            { "Where did Daedus go?  He left us so long ago. I hope he wasn't swayed by that Harlet Gothivia. She seemed power obsessed and hungry. Maybe that's just me though", "代達斯去哪了？他很久以前就離開我們了。我希望他沒有被歌瑟梵影響。她似乎對權力著迷並且渴望權力。也許這只是我這麽覺得吧。" },
            { "I might be the only one but, Ereshkigal is kind of hot isn't she? Hell you wouldn't even know would you. You're taste in women is flat.", "或許只有我一個人覺得，但是厄莉什基迦勒確實有些性感，不是嗎？什麽，你說你不知道？！不是？哥們！你對女人的品味也太差了吧！" },
            { "You don't understand how we are. We're higher than all below us, which is everyone except a god. Only they can be held to such high status. Squirm off you worm.", "你不會明白我們是怎樣的存在。我們比除了神之外的所有人都高貴。只有神才能擁有如此高的地位。爬吧，你這蟲豸。" },
            { "I wish Sigfried didn't go insane. He's such an asshole, even our dear Ereshkigal left with him to seal him away...  ", "我希望齊格飛沒有發瘋。他真是個混蛋，就連我們親愛的厄莉什基迦勒也離開我們去封印他了……" },
            { "Maybe I may be the only person to question the gene pools of these people. Like where do they all look so pretty from??? Im wearing this mask cuz I look like a goblin.", "也許我是唯一一個質疑這些人基因的人。比如他們都是從哪裏遺傳來的美貌？？？我之所以戴著這個面具，是因為我長得像哥布林一樣..." },
            { "I want a beach episode with Zui and Ereshkigal now! ", "我現在就想看到蕊和厄莉什基迦勒的海灘寫真集！" },
            { "I would want to be more powerful but that takes a lot of training. Anyone who dares to take more than what they are given should be punished. ", "我想要變得更強大，但這需要大量的訓練。任何敢於索取超出所給予的人都應該受到懲罰。" },
            { "Those guys in the well? They are trapped down there because they made some goofy deals in their lives to get more power and just like the great Veil people we are, we trapped them away for good.", "那些在井裏的人？他們被困在那裏，因為他們在生活中做了一些愚蠢的交易來獲得更多的力量，就像我們這些偉大的天紗人一樣，我們永遠地困住了他們。" },
            { "I don't know what the outside world is like.", "我不知道外面的世界是什麽樣子的。" },
        });
        #endregion
        #region Merena 梅瑞娜
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), nameof(Merena.SetBestiary), new() {
            { "Magic Magic MAGIC", "魔法，魔法，還有更多魔法！" },
            { "Merena the bewitched sorcerer", "著迷術士梅瑞娜" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), nameof(Merena.GetChat), new() {
            { "Funny enough the clothier used to come through here all the time for some of our amazing fabrics", "說起來，服裝商經常來這裏買我們的魔法絲綢和布." },
            { "I wonder what my sister Sylia is up to nowadays, do you know her?", "你最近有見過一個叫賽利亞的人嗎？她跑哪去了..." },
            { "I'm gonna be the very best, like no one ever was... ", "我要成為史上最強的魔法師！" },
            { "Fenix is the best queen there will ever be! She gives us all what we want :P", "緋琦真是理想中的皇後！她給了我們一切！" },
            { "This place is so calming, I can't stand it but I would give everything to be near Fenix", "這地方太安靜了，我不喜歡，但能夠站在緋琦身邊，這點小事不算什麽." },
            { "Aimacra seems pretty cool, she came here recently looking for some brooches", "安魅凱拉很棒哎.她最近來這裏尋找飾符來著." },
            { "Hey uh could you do something for me? I have a little favor, just ask what it is!", "呃..你能稍微幫我個忙嗎？會有回報的！" },
            { "I've always wanted to be the best witch there is! I've always been outshined by exiles though, including my sisters sadly.", "我一生的夢想就是成為最強的女巫！但我總是被人超越，尤其是我的姐妹." },
            { "I really need to beat my sister in a battle someday.", "哪天我見到她了，一定要當場打敗她！" },
            { "It's strange, the economic system here is almost like communism", "奇怪，這裏的經濟怎麽這麽像...共產主義？" },
            { "Damn we have some cool shit here", "這裏的東西都好棒啊！" },
            { "No doubt about it but Fenix is truly the strongest witch in all of the lands, maybe even more powerful than the witch of light in the hallow, I don't like her.", "毫無爭議，緋琦才是這片大陸上最強的女巫.可能比神聖的光之巫女還強.我恨那家夥." },
            { "Hahh, I remember that goon Verlia, she's kind of dumb but shes at least powerful, I remember she got exiled for stealing tomes, I might need that from her.", "哈，我還記得那個薇莉婭.腦袋一根筋，但力量還挺強.她因為從皇都偷了魔法書而被流放.我可能還需要那本書." },
            { "Can you go collect some runes for me? I'd love for you to get working.", "呃..你能稍微幫我個忙嗎？會有回報的！" },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(Merena), nameof(Merena.SetNPCNameList), new() {
            { "Merena the Sorcerer", "術士梅瑞娜" },
            { "Merena the Sorcerer", "術士梅瑞娜" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), nameof(Merena.SetChatButtons), new() {
            { "Merenas Quest", "任務" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_VerliaStart", new() {
            { "What are you standing there for, go kill Verlia! She's an enemy of the royal capital and she has a book I need lmao", "別光站著，去幹掉薇莉婭！她從皇都偷了一本書，我需要！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_VerliaComplete", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "哇，謝了！接下來我想要幽曦村落裏的一個特殊球體，那裏面蘊藏著世間獨一無二的魔法，我想好好研究一下它到底是怎麽形成的，而且這本書裏也提到了需要它." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MorrowStart", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "哇，謝了！接下來我想要幽曦村落裏的一個特殊球體，那裏面蘊藏著世間獨一無二的魔法，我想好好研究一下它到底是怎麽形成的，而且這本書裏也提到了需要它." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MorrowComplete", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "哇哦~看看這精美的橙色條紋，看看從這裏流出的魔力！你居然真的把它搞到手了！非常感謝！接下來拿給我100個粉塵袋就好了，是釀造藥水用的." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_DustBagsStart", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "哇哦~看看這精美的橙色條紋，看看從這裏流出的魔力！你居然真的把它搞到手了！非常感謝！接下來拿給我100個粉塵袋就好了，是釀造藥水用的." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_DustBagsComplete", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "好樣的，這對你來說沒什麽難度吧？接下來我需要一些含有魔法的紙張.困難模式各地都出現了特別的怪物，從它們身上收集材料.去吧！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MagicPaperStart", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "好樣的，這對你來說沒什麽難度吧？接下來我需要一些含有魔法的紙張.困難模式各地都出現了特別的怪物，從它們身上收集材料.去吧！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MagicPaperComplete", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abyss. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "哦哦哦太棒了！還有最後一件事想要拜托你.傳說，古時候有個賊偷了一本極其重要的古籍，並藏在無盡深淵之下.你能去找找它是不是真的存在嗎？無論花多久都是值得的..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_TomeStart", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abysm. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "哦哦哦太棒了！還有最後一件事想要拜托你.傳說，古時候有個賊偷了一本極其重要的古籍，並藏在無盡深淵之下.你能去找找它是不是真的存在嗎？無論花多久都是值得的..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_TomeComplete", new() {
            { "THANK YOU THANK YOU THANK YOU, omg this is the best day of my life! I never knew this actually existed! Were the rumors true??! dsfjhnbhfribdhs- Nevermind who cares anymore, we can both be the best mages ever! I open my shop to you and here, a token of my graditude. ", "我的天吶！！！我一生都在等這一天！！它居然真的存在！那些故事都是真的...哇哇哇哇哇——誰還管那些啊！我們一起來做世界上最厲害的魔法師吧！！感激不盡，我會把我有的一切都賣給你！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "StartQuests", new() {
            { "Hey, I have nothing else for you to do! Thanks for all of your help, have you checked out my shop yet?", "感謝你，我心願已了！來看看我的商店吧！" },
        });

        // 主要用於商店註冊, 如果同時啟用 Shop Expand 能在查詢商店時看到漢化效果
        Dictionary<string, string> merenaQuestSystemConditionLocalizations = new() {
            { "KillVerlia", "需要擊敗薇莉婭" },
            { "ExploreMorrowedVillage", "需要探索古諭村落" },
            { "Give100DustBags", "需要上交 100 個粉塵袋" },
            { "MakeMagicPaper", "需要製作魔法紙張" },
            { "Tome", "需要製作終極魔導書" }, // MakeTomeOfInfiniteSorceryCompleted
        };
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionKillVerlia", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionExploreMorrowedVillage", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionGive100DustBags", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionMakeMagicPaper", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionTome", merenaQuestSystemConditionLocalizations);
        #endregion
        #region NaturalWitch 自然女巫
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetBestiary), new() {
           { "Steaming from the depths", "地下深處的火焰與濃煙" },
           { "Ordin, The New Monarch", "星樹新君奧丁" },
       });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.GetChat), new() {
           { "Shes got some great cogs", "此女身懷絕技，機巧非凡" },
           { "Remove yourself from my sight", "速速退出吾之視線！" },
           { "You walk like an infant with no tucas", "汝行步蹣跚，猶如初生之犢未諳世故" },
           { "What a pitiful endearment, praise to the ones above.", "何其微薄之寵愛，竟上達天聽" },
           { "...", "..." },
           { "You are not fit to become a god", "爾非神格之材，何足論天地主宰" },
           { "Oh Sigfried, return in good health or I shall slay you with my own hands from such a succubus!", "齊格飛，汝必全軀而返，否則吾將親往，以吾之手，將汝從那妖婦之爪中解脫！" },
           { "Bring me their Manifestations", "將彼等之具現體，悉數呈於吾前" },
       });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ordin), nameof(Ordin.SetNPCNameList), new() {
           { "Ordin, Illurian Monarch", "星樹之君奧丁" },
           { "Ordin, Illurian Monarch", "星樹之君奧丁" },
       });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetChatButtons), new() {
           { "Reminisce of Sigfried", "回想齊格飛" },
       });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.OnChatButtonClicked), new() {
           { "Thy is so resilient, unhand me from these this trecherous nagging and take this for thy shall not be astute to your prescence no longer.", "汝之糾纏，已至厭煩。收下此物，速速離去，莫再擾吾安寧，汝之行徑，實難容忍" },
           { "To be one of the forth or forward, the lands that I rest in reek of falsification of hypocrisy and power.", "欲居人先，而吾所駐之地，充斥偽善與權力之虛飾" },
           { "Sigfried was once a young fellow, thy brother in one's eye's and a villian in anothers'.", "昔日齊格飛亦是少年郎，於汝眼中似兄弟，於他人則如惡徒" },
           { "Our sacred castle falls ill to such burning. Our wishes have been grafted under the curse of Sigfried's unveiling.", "吾等聖堡，竟罹此焚劫。吾心所願，悉於齊格飛揭咒之下，已非昔比" },
           { "Fall away, dear brother ", "汝且安臥於斯，余生休再相見" },
           { "Mark thy words with caution. Ereshkigal is a loveless harlet who took the life of the brother of many. Yet thy fulfills their prophecy among lovers, hence she is not a false goddess.", "慎爾言辭。厄莉什基迦勒，癡戀之狂淵巫女也，奪多兄之命。然其於戀人中預言成真，故非偽神" },
           { "All our goals are put to rest following the lands of the veil. Finish all those who have wronged our beloved world.", "吾等宏圖，隨天紗之土而偃息。凡逆吾心愛之世者，必盡數了斷" },
           { "Manifest their souls and bring them to my company. You shall be rewarded until the rekoning begs for your place to be silenced. ", "昭其靈魄，引之吾側。厚賞於爾，迨天命緘默" },
           { "Niivi, the protector of the lands of the veil, yet curse all upon thy brother to be selfish and steal among those of power and wealth. He was greedy and in his expense payed the lovers' prison.", "尼伊維，天紗之域守護者，竟詛咒汝兄，令其於權財中獨占且竊。貪婪之行，致戀人陷囹圄" },
           { "Now I sit ill waiting for the lands of the veil to change.", "今吾抱恙而坐，靜待天紗之域變遷" },
       });
        #endregion
        #region PULSARHOLE 脈 沖 黑 洞
        // 暫無需要強製本地化的內容
        #endregion
        #region Sirestias 希絲忒莉亞
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetBestiary), new() {
            { "Your eternal bonding with this individual resonates with everyone throughout!", "你與這位存在之間永恒的羈絆回蕩不絕..." },
            { "Sirestias", "希絲忒莉亞" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.GetChat), new() {
            { "Here to give me some company I see?", "哦？來陪陪我嗎？" },
            { "Hmph how's Aimacra doing? Nevermind I already know that answer.", "嗯，安魅凱拉怎麽樣了？算了，我又不是不知道." },
            { "Enjoying yourself?", "玩的還開心嗎？" },
            { "Sometimes I forget you're bounded with me always", "我都快忘了你和我已經綁定在一起." },
            { "Its always sweet to see you do things for me", "你願意為我做事，我真是欣慰啊." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Sirestias), nameof(Sirestias.SetNPCNameList), new() {
            { "Sirestias", "希絲忒莉亞" },
            { "Sirestias", "希絲忒莉亞" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetChatButtons), new() {
            { "What do I do next?", "接下來做什麽？" },
            { "Give Completion Idol", "給予隕神之像" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.OnChatButtonClicked), new() {
            { "Kill the stone guardian, commander gintzia will soon raid you with his army of failed troops from the govheil. He will be very easy so take him swiftly and beat him into submission hun. ", "擊敗那個守衛之後，金戈亞指揮官很快就會從歌維赫堡率軍入侵.他就是個軟柿子，速戰速決，把他打趴下！" },
            { " I'd recommend going into the Fabled Swamp over to the right or collecting resources to get ready to fight either Jack or find a sun alter in a desert and prepare for Sunstalker! Zui may be a good person to talk to in the witch village for quest items too :) ", "我推薦去古諭之地探索，或者收集材料挑戰燈籠傑克或者獵日遊隼.如果你想幹些別的，去左邊的女巫村落找蕊吧，她有事情要拜托你." },
            { "Nice babe, I want you to go kill Jack in the Fabled swamp on the right then, you need a wandering essence and he shouldn't be too difficult. ", "好樣的寶貝.接下來去右邊的古諭沼澤幹掉燈籠傑克吧.他不是很強，只要有漂浪焰華就能把他召喚出來." },
            { "Nice work! I want you to go headhunt a bird in the desert, his name is Sunstalker and they are a bit challenging but less so than the last, collect some mandibles in the desert to make the Sun stone! Find the alter on the surface of a desert!", "幹得好！是時候去沙漠裏打鳥了.它叫「獵日遊隼」，有些挑戰性，但不太多.用蟻獅上顎做出它的召喚物，在沙漠地表找到它的祭壇！" },
            { "You're next target is Daedus, he's a strong one. Hes a very loyal Guardian to one of the biggest threats here being Gothivia, we need him gone to get to the big fish in the sea. For some reason he holds some power of a singularity so beware. He resides low in the temple in the Fabled Swamp, no extra preperation needed.", "下一個目標，守護者代達斯.他力量不凡，是歌瑟梵的盡忠護衛，也就是說，是釣上這條大魚的重要一環.他擁有一顆奇點的力量，小心！他目前沈睡於古諭地下，不需要做什麽額外措施就可以去挑戰." },
            { "Oh my gosh nice, so here's where things are going to get difficult. If a blood moon happens we need to exterminate Dreadmire, she spawns after killing a blood cyst during a blood moon, you can also get some terror fragments too! She'll pose too much of a threat if we let her live. She's I think one of the three sisters, formally known as cozmire. She needs to die and after that I'll give some great rewards.", "好嘞，接下來的任務可能有些難度了.如果血月發生，我們需要抓住機會幹掉絳淵惡巫.打破血肉囊或者收集恐懼殘片來召喚她.她是天紗三姐妹之一，曾經被稱作「天寰神巫」，留她活著風險太大.如果幹成，獎勵自然會有的." },
            { "We are making big progress now! I don't know if you have been killing other ravenous monsters but I'd recommend doing so as the next one on our list is Verlia but to get to her we have quite a few things to do first. Make yourself a void key and find a temple deep in the ice biome, there should be some loot and hopefully an alter that'll give you a lantern. She was trapped by Fenix but she needs to die so we can bring out Gothivia.", "我們的計劃正大步前進！我不清楚你最近又幹掉了哪些怪物，但是時候幹正事了.名單上的下一位是薇莉婭.在見到她之前還有不少事情要完成.去弄到一把虛空鑰匙，在冰雪地下的神殿中有不少東西等著你.找到祭壇，擊敗那個守衛，拿到提燈.薇莉婭的靈魂被緋琦囚禁在那裏面，但我們需要讓她徹底死掉，來引出歌瑟梵." },
            { "Ok you got the lantern! Go to the cathedral overtop the ice biome and summon her at the top at night. This will be our biggest foe yet but I know you can kill her, sorry Aimacra is tired of being my assasin so it's your turn.", "OK，你拿到那盞燈了！等到晚上去到冰雪地聖殿的頂端釋放她.這是直到如今我們最大的挑戰，但我相信你的能力.抱歉，安魅凱拉不想再被我當刺客使喚了，這次輪到你上了！" },
            { "Oh damn this is great. I think that completes our list for now, check back in with me in Hardmode! We'll purify this world of all danger and create peace and then we can be together and move on. Thank you again.", "哦天，這也太棒了！我們現階段的任務全都完成了！等到你打敗了血肉墻再來找我吧！我們一定能凈化這個世界上的一切威脅，一起向前.感謝你的付出." },
            { "Welp here we go again. So theres a strange issue we have, so Daedus isn't the only barrier to trying to stop us from getting to Gothivia, Aimacra just went and explored around and found some new places and there was this castle underground in a green biome? I noticed Gothivia's marks on it and the Sun hasnt started turning green, could you look at that? There should be some catacombs underground in the desert, ocean and caverns to help power up too.", "喲，又見面了.我發現了個問題，代達斯並不是歌瑟梵築起的唯一一道障礙.安魅凱拉剛在那個綠油油的地方地下找到了一座城堡，上面有歌瑟梵的印記，你能去看看嗎？至少太陽還沒變綠，說明我們還有時間.還有，沙漠地下，海洋裏，洞穴中存在著三座墓穴，裏面的東西應該會幫到你." },
            { "There was a person down there claiming to be Gothiva? Thats strange. Gothivia seems to be making an appearance on the world. Apparently things are changing the skies and things are falling from them, Beware of STARBOMBERS, Aimacra warned me that they were manufactured here as well as Ekrose and you have experience with them.", "那邊有個人在假裝歌瑟梵？奇怪.歌瑟梵本人貌似也正在趕回這個世界.再者，這個世界的天空好像出現了些異變，掉下奇怪的東西.小心 星 爆 者，安魅凱拉告訴我它們在這裏也有被製造，和在艾科洛斯一樣." },
            { "I didn't think Rosemary's creations would've made it here. Ekrose sure does have an affect on this world. I saw some strange disturbance on the left side of the underworld though, can you check that out? I went to talk to Veldris and he told me Sylia may be up to some demonic magic that could ruin our process, so killing her is a good option. ", "我之前還覺得迷叠香城的造物不會出現在這裏呢.看來艾科洛斯和這個世界確實有一定聯系.我感受到地獄的左側有個奇異的能量擾動，維爾德斯告訴我那可能是賽莉亞搞的鬼，她的黑暗魔法可能會阻礙我們，我們要先發製人把她除掉." },
            { "It was a void witch... Interesting. Must be related to that Merena person Aimacra talked about. I haven't been to the Royal Capital much, mainly because it's so far out but maybe we should kill the Queen there, she is definitely extremely powerful but I don't really know how to talk to her, I haven't seen her yet. If you can could you go kill her for us? ", "虛空女巫...真有意思.應該和安魅凱拉說的那個梅瑞娜有點關系.我沒怎麽去過皇室首都，那裏太遠，但那個女王也在我們的名單上.她的力量很強，而且我沒和她溝通過.要不你去把她幹掉？" },
            { "Ereshkigal huh? I think I know her, she also isn't supposed to be here. However she got lost I guess we can give her some sense", "厄莉什基迦勒？我知道這個名字.她也不應該出現在這裏的.如果她是迷路了，我們也許可以幫幫她？" },
            { "Weheeee! You're doing so well! I can like get off to this! I'm kidding :(. Maybe you can try and explore around some more. We need to prepare for moonlord!", "哇嗚！你也太高效了！我要不要直接讓你接手整個計劃呢...開玩笑的啦.接下來你就自由探索吧，好好準備迎戰月球領主." },
            { "I did not expect you to want to kill her honestly. I went and explored around and she seemed nice. Wait you didn't kill her? Oh dang, well she isn't on our list anyway so it's fine lmao. She isn't causing us any issues.", "我真沒想到你去打她...我在四處轉悠的時候遇見了她，感覺她還不錯的.你說你沒殺了她？也好，反正她也不在我們的名單上，也沒給我們添亂." },
            { "Ok ok we got some good stuff done. Time for Gothivia as she's not particularly the worst but she keeps inspiring bad people to do ad things and we need to teach her not to do that.", "幹得不錯.是時候去找歌瑟梵了.憑心而論她並不壞，但她的領導力總能激勵壞人去幹壞事，我們就給她一個教訓，讓她停止這樣." },
            { "Maybe we shouldn't have killed her, I don't know if there was a reason to kill Niivi. You just wanted weapons and gear? I mean if it helps I guess. She was doing more good than harm", "我本來沒想殺她的，我們沒有理由對尼伊維下手.你想要裝備？要是有幫助的話，那好吧，但她可沒有做任何惡事." },
            { "Okie dokie, Gothivia has agree to stay calm so we aren't going to assassinate her anymore, I feel bad for killing her sister now. I hope Vixyl doesn't find out.", "好好，歌瑟梵答應暫時保持冷靜，我們應該不用刺殺她了.我現在對殺了她的姐妹感到有些抱歉...希望維西爾不會發現吧." },
            { "YESSS, we're getting closer to our goals!! Aren't you excited <3", "好耶！！我們距離目標又進了一步！你不覺得激動嗎？<3" },
            { "I couldnt find anything more so I'll give you an extra token!", "我也沒找到什麽更好的東西，所以多給你一顆寶珠吧！" },
            { "Please go do something for me, we don't have all day you know ;P", "去做些我規劃的事吧，咱們的時間可不多啊." },

        });
        #endregion
        #region UnknownSignal 神秘信號源
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetBestiary), new() {
            { "An Unknown Signal", "一個未知的信號從這裏發出" },
            { "Unknown Signal", "神秘信號源" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.GetChat), new() {
            { "A static voice confirms the identity of the user, you are in the right place.", "一個模糊的聲音確認了你的身份.看來這裏是對的." },
            { "A static voice confirms the identity of the user, you are in the right place.", "一個模糊的聲音確認了你的身份.看來這裏是對的." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetChatButtons), new() {
            { "Touch Unknown Circuitry", "觸碰" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetNPCNameList), new() {
            { "Unknown Signal Source", "神秘信號源" },
            { "Unknown Signal Source", "神秘信號源" },
        });
        #endregion
        #region Veldris 維爾迪斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.SetBestiary), new() {
            { "Freezing to death", "冰寒刺骨" },
            { "Veldris the assassin", "刺客維爾迪斯" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.GetChat), new() {
            { "Shes got some great cogs", "她的零件不錯" },
            { "Who's next on this list to kill?", "下一個殺誰？" },
            { "How are you doing? ", "近來如何？" },
            { "I need to gamble a bit more today", "一會我還得再去賭幾局." },
            { "That Sirestias woman creeps me out.", "那個希絲忒莉亞真的很嚇人" },
            { "I gotta get to the Royal Capital some day. Maybe they can empower my weapons.", "哪天我一定要去一趟皇都.他們應該能讓我的武器更強" },
            { "So coldddd", "好冷——" },
            { "Hey you, come buy some stuff from me!", "嘿，你！過來買點東西！" },
            { "Im starting to warm up this winter", "冬天也不那麽冷了" },
            { "Everyone and all this damn god talk, it makes me crazy", "所有人都在說什麽亂七八糟的神，快把我逼瘋了" },
            { "Interestingly, I don't know why those sisters all are disconnected, it seems like they're always hiding something", "我完全不懂那些姐妹們為什麽都不彼此聯系.難道她們有什麽不可告人的秘密？" },
            { "I wish I was someone important", "我要是個重要人物該多好啊" },
            { "Sometimes I wanna lead an army you know? I just wanna see Veiizal again", "有的時候我也想帶著一支軍隊四處征戰，但我只是想再見見維依佐" },
            { "You gonna buy something lad?", "需要什麽嗎，小夥子？" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetNPCNameList), new() {
            { "Veldris the Calm Assassin", "沈靜刺客維爾迪斯" },
            { "Veldris the Calm Assassin", "沈靜刺客維爾迪斯" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetChatButtons), new() {
            { "Talk", "閑聊" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.OnChatButtonClicked), new() {
            { "You doing good? I mean it's a hellhole out here. Sometimes I even start to wonder what brings you here. I'm just some lonesome seller, just be sure not to get on someone's deadlist or else I'll be seeing ya. ", "近來如何啊？外面都亂成一鍋粥了，得虧你還想來.我？我就是個賣雜貨的而已.只要你別惹上什麽大人物，咱們應該不會有刀劍相向的那一天." },
            { "Everytime I hear someone talk about gods I want to just puke in their faces, like ew. I'm kind of glad that Sirestias woman is getting rid of them. Her and Fenix don't seem all too power driven. Fenix is just revenge driven, and I can respect that.", "每次我聽到有人提那些神我都覺得不可忍受.希絲忒莉亞想要把它們全幹掉我可太支持了.她和緋琦一樣，都不是那種盲目追求力量的人.據我所知緋琦只是想要復仇，這我完全能理解." },
            { "If my weapons we're ever used, they better be in the right hands. My tools were crafted with some Luminull and some special metals, they better hold together- I had to steal some stuff from that Illuria place", "想要用我的武器，就小心點用，別把它們弄散架了.那可都是黯光和特殊合金做成的，為了造它們我特意去星樹偷來的材料！" },
            { "I'm just gonna rant about this Illuria place honestly. WHY IS THERE A DRAGON JUST ROAMING. Like I thought those went extinct with the the virulent- oh I meant acid. I really just needed some scales but oh noo the watcher of society is there. ", "我真想好好吐槽一下那個星樹.為什麽那有條龍啊？而且她就那麽若無其事地在閑逛！他們不是已經在瘴煞-酸蝕-那裏被滅絕了嗎？我想搞點鱗片，但一直有人看著..." },
            { "Back in my day building this house was my masterpiece, Fenix really gathered up an army just to build this cathedral here and that temple below just to trap some harlet who took her stuff. Down right evil though on Fenix's behalf, maybe overkill. ", "之前，這棟建築可算得上是大師之作.然後緋琦集結了她的整支軍隊就為了建那座大殿堂來困住某位偷了她東西的婊子...要我說，純純的邪惡做法，而且太過了." },
            { "Some knights visited me the other day talking of this 'peace and formality' and I couldn't take it so I went to the Lunar tree, which for some reason they live on and I stole some fragments and some luminull? It seems pretty powerful and is probably related to Lumi in some way.", "前幾天有幾個騎士經過這裏，一直說著什麽「和平與禮儀」，我實在受不了他們的嘮叨了，就去了星月巨樹，他們居然住在那上面？我從那拿了些材料，感覺力量很強，說不定都和天紗琉明有聯系." },
            { "I love myself commissions, just sayingg if you wanna commission me I'm all available, the last person I went to kill was some goofy guy named Rallad, some girl named Sylia asked me if I could do it for her since she didnt want to be seen, took forever to find him though. ", "有活幹的時候最舒服了.你要是看誰不順眼，就來找我吧.上一個給我委托的叫賽利亞，她讓我去幹掉一個叫瑞拉德的家夥，可找了我好一陣子." },
            { "Interestingly enough me and Sylia have fun sometimes, shes pretty nice once you get to know her, sadly she stays away from her sister Merena and the rest of the capital, she's pretty chill. Kind of wanna travel with her though. ", "我和賽利亞還算相處得來，只要你了解她，她還是很有趣的.她一直在回避皇都和她的姐妹梅瑞娜.之後有空的話我想和她一起去旅個遊之類的." },
            { "The small joys of life comes from not having your house destroyed by some malevolent gods throwing down their trap cards when youre trying to sleep. It makes me annoyed when I have to peek out my window to make sure the black hole isn't going to hit my house.", "想象一下，你在屋裏睡得好好的，某個神朝你這邊扔了一張陷阱卡，整棟房子就毀了，很煩人對吧？我還得天天朝外看著，提防黑洞." },
            { "You knowww, I was named Veldris by my friend, I always grew up without a name since my parents died by a stupid raging black hole guy, name was Sepsis I believe? He killed off so much 30 years ago yet I remember it like yesterday.", "在我還小的時候，還沒等到取名，我父母就被一個該死的瘋子給害了，好像是叫...星爍.那是30年前的事，但我仍然記憶猶新.我現在這個名字還是一個朋友給取的." },
        });
        #endregion
        #region Zui 蕊
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), nameof(Zui.SetBestiary), new() {
            { "A traveller of the lands who may hold great power", "一名周遊大陸的旅者，似乎掌握著強大的力量." },
            { "Zui the Traveller", "旅者 蕊" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), nameof(Zui.GetChat), new() {
            { "The dryad is pretty fun after all, she's pretty sweet and helps us with the gardening!", "樹妖是個好人呀！她對我們都很友好，還幫我做些種花的雜務！" },
            { "We've had to kick a few witches out of this town you know, its quite a shame..", "我們之前不得不把幾名女巫從這裏趕了出去，真可惜啊..." },
            { "I keep going out to find more plants but somehow you're always here when I return. ", "我其實沒有一直站在這裏不動.只是碰巧每次你來我都在這裏而已." },
            { "I'm trying to find a way to stop the corruption and virulent from spreading but I have no fix currently.", "我在想辦法阻止邪惡地形和瘴煞之地的擴散，但目前為止我還沒想出什麽良策." },
            { "Hey love, you know you could be collecting stuff for me!", "如果你正閑著，去給我收集一些東西如何？" },
            { "Sirestias? Oh um yeahh we go pretty far back.", "希絲忒莉亞？啊...對...我和她有過一段交情." },
            { "Aimacra is cool too, this is my first time meeting her lol", "安魅凱拉也挺棒的，雖然我才認識她." },
            { "I wouldn't say I'm too powerful, afterall I a just a traveller", "我很強嗎？不不不，我只是個旅者而已." },
            { "Sometimes I wonder what they did in Vodhome after we all left. I really have to catch up with Sirestias and the others.", "我在想，我們離開了那裏之後，沃德府怎麽樣了.看來有必要去和她們敘敘舊了." },
            { "Are you here with Sirestias?", "你是和希絲忒莉亞一起來這裏的嗎？" },
            { "All these plants are so cool! I did just arrive here before Sirestias, there was some commotion and I think people here are trying to disrupt time and power.", "這裏的植物太棒了！我比希絲忒莉亞早一小會來的，當時正趕上一片騷亂，好像是有人想要擾亂時間和能量." },
            { "Sirestias is a balancer, same goes for me but I like to just collect things.", "希絲忒莉亞的目標是「平衡」.其實我也一樣，但我還是更喜歡幹些悠閑一點的事，比如收集些植物." },
            { "Hey if you collect some items for me I can give you some stuff!", "幫我收集我想要的東西，我能給你獎勵！" },
            { "Hey can you go collect for me?", "幫幫我嘛~" },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(Zui), nameof(Zui.SetNPCNameList), new() {
            { "Zui The Traveller", "旅者 蕊" },
            { "Zui The Traveller", "旅者 蕊" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), nameof(Zui.SetChatButtons), new() {
            { "Zui's Quests", "任務" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_NotCheckmarked", new() {
            { "Hi hii! Thanks for asking! Could you fetch me some plants, you can use this bag! Just fill it up with some different types of plants and I'll give you some stuff afterwards!", "嗨~謝謝你來幫我！給我收集一些植物之類的吧，就裝在這個袋子裏！我會給你回禮的！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_NotCheckmarkedHardmode", new() {
            { "Hehe I'm gonna up the difficulty of these, I'm gonna need some bigger plants, so you'll need to fill up this bag! Thanks!", "嘿嘿，接下來的任務有點難了哦.去給我找一些更加稀有的植物吧，裝滿這個袋子就行！感謝！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_1Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "好的，這些我就收下了，拿好你的獎勵！能再給我收集一點嗎？" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_16Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "好的，這些我就收下了，拿好你的獎勵！能再給我收集一點嗎？" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_3Complete", new() {
            { "Ok ok, 3 quests is kind of good, thanks for caring a lot about this! I've got more items in my shop for you, bring me 3 more and I'll get more for ya!", "完成3個任務了，棒哎！我在商店裏給你準備了更多好東西！再來3個，還有更多驚喜！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_6Complete", new() {
            { "6 Quests is actually kind of crazy, I've opened up with a few more items for you if you want! Bring me 4 more ;p", "6個任務，瘋狂！我又進了一批你可能想要的好東西！再給我收集4個吧 ;p" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_10Complete", new() {
            { "Damn, 10 quests? You're on a role you know! I've got some more items for you in my shop actually, I went travelling and Sirestias gave me a few items! I'll give you some more items if you can do 10 more!", "哎呀，10個任務完成了？你真是前所未有啊！正好前段時間我去找希絲忒莉亞，她給了我些東西我都放在商店裏了，你看看吧.再做10個任務，還有好東西！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_20Complete", new() {
            { "You have finished 20 quests for me! Thank you! I've got more items in my shop because of it too! If you want more from me bring me ten more and maybe we can have some fun! ", "你完成了20個任務！萬分感激！我的商店裏又有新東西啦！還想要更多？再完成10個任務，就差不多到了咱們的玩樂時間啦！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_30Complete", new() {
            { "My graditude is of the utmost thanks, in return you can have anything in my shop! And I'll help you out personally sometime if you need me ;p ", "真是太太太感謝你了！我的商店完全對你開放了！等以後你需要我的幫助時，我一定會答應的 ;p" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "StartQuests", new() {
            { "Hiya! I think that's all the things I need, you can get some stuff in my shop but thanks babe!", "嗨呀！我覺得我需要的東西已經夠用了.謝謝你的好意，看看我的商店如何？" },
        });

        // 主要用於商店註冊, 如果同時啟用 Shop Expand 能在查詢商店時看到漢化效果
        Dictionary<string, string> zuiQuestSystemConditionLocalizations = new() {
            { "ThreeQuests", "需要完成三個任務" },
            { "SixQuests", "需要完成六個任務" },
            { "TenQuests", "需要完成十個任務" },
            { "TwentyQuests", "需要完成二十個任務" },
            { "ThirtyQuests", "需要完成三十個任務" },
        };
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition3", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition6", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition10", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition20", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition30", zuiQuestSystemConditionLocalizations);
        #endregion

        #region ZuiDeath
        ForceLocalizeSystem.LocalizeByType(typeof(ZuiDeath), nameof(ZuiDeath.AI), new() {
            { "I think I have a headache..", "我的頭好暈..." },
            { "I'll see you later at my shop! Fun time :)", "幹得好！想要找我的話就再來我的商店吧！" },
        });
        #endregion
        #region ZuiTheTraveller
        ForceLocalizeSystem.LocalizeByType(typeof(ZuiTheTraveller), nameof(ZuiTheTraveller.SetBestiary), new() {
            { "Zui, not exactly someone that can be killed but loves to play around I guess? Sirestias is closely accompanied with her", "蕊，絕不是什麽等閑之輩，但看樣子很喜歡休閑玩樂.希絲忒莉亞與她有不淺的交情." },
            { "Zui the Radiance", "輝光女神 蕊" },
        });
        #endregion
        #region EreshkigalIdle
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetBestiary), new() {
            { "A mystical veil user who took accountability to chain up Sigfried", "禁錮了齊格飛的神秘人物" },
            { "Ereshkigal the Lover", "癡戀者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.GetChat), new() {
            { "Leave me and my husband alone", "讓我和我的丈夫在這裏獨享二人時光吧" },
            { "You should all be jealous that I'm here.", "你們都應該羨慕我！" },
            { "Welcome welcome! Come here to feast your eyes on us?", "歡迎！歡迎！來一飽眼福吧" },
            { "Oh dear Sigfried how we've met..", "親愛的齊格飛...我還記得我們相遇的那天..." },
            { "Come and go you will, you'll be broken more than the others.", "匆忙的來，匆忙的走，將自己搞得支離破碎..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetNPCNameList), new() {
            { "Ereshkigal the Lover", "癡戀者厄莉什基迦勒" },
            { "Ereshkigal the Lover", "癡戀者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetChatButtons), new() {
            { "Give her something.", "給她送一件禮物" },
            { "Sigfried?", "詢問關於齊格飛" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.OnChatButtonClicked), new() {
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
    }
}
