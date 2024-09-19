using Terraria.GameContent.UI;
using Terraria.Localization;
using LunarVeil = Stellamod.Stellamod;

namespace LVTC.Miscs;

public class CurrencyLocalizer : ModSystem
{
    public override void Load()
    {
        // 這裏不用填漢化內容, 去 Mods.Stellamod.Currency.hjson 填就好了
        HandleCurrency(LunarVeil.MedalCurrencyID, "RuinMedals");
        HandleCurrency(LunarVeil.MOACurrencyID, "ManifestationOfAnxiety");
        HandleCurrency(LunarVeil.MOBCurrencyID, "ManifestationOfBravery");
        HandleCurrency(LunarVeil.MOCCurrencyID, "ManifestationOfCommittment");
        HandleCurrency(LunarVeil.MOHCurrencyID, "ManifestationOfHumility");
        HandleCurrency(LunarVeil.MOLCurrencyID, "ManifestationOfLove");

        static void HandleCurrency(int currencyId, string currencyName)
        {
            if (CustomCurrencyManager.TryGetCurrencySystem(currencyId, out CustomCurrencySystem? system))
            {
                if (system is CustomCurrencySingleCoin ccsc)
                {
                    var oldKey = ccsc.CurrencyTextKey;
                    ccsc.CurrencyTextKey = $"Mods.Stellamod.Currency.{currencyName}";
                    Language.GetOrRegister(ccsc.CurrencyTextKey, () => oldKey);
                }
            }
        }
    }
}
