namespace LVTC.Projectiles;

internal class MiscProjectileLocalizer : ModSystem
{
    public override void Load()
    {
        #region AuroreanStarbomber
        ForceLocalizeSystem.LocalizeByTypeName("AuroreanStarbomber", "SpawnStarBomber", new() {
            { "STARBOMBER crashes down!", "星 爆 者 從天砸落！" },
        });
        #endregion
        #region BloodLampProjectileModifications
        ForceLocalizeSystem.LocalizeByTypeName("BloodLampProjectileModifications", "OnHitNPC", new() {
            { "This NPC has been hit with a modified projectile ", "此NPC被特殊彈幕擊中 " },
            { " times.", " 次." },
        });
        #endregion
        #region ProjectileModifications
        ForceLocalizeSystem.LocalizeByTypeName("ProjectileModifications", "OnHitNPC", new() {
            { "This NPC has been hit with a modified projectile ", "此NPC被特殊彈幕擊中 " },
            { " times.", " 次." },
        });
        #endregion
        #region IgniterStart
        ForceLocalizeSystem.LocalizeByTypeName("IgniterStart", "OnHitNPC", new() {
            { "STRIKE!!", "攻擊！！" },
            { "MAGIC!", "魔法！！" },
        });
        #endregion
    }
}
