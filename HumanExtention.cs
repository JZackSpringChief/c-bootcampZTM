

public static class HumanExtentions
{
    public static string WeaponAndAttackPower(this Human Hero)
    {
        return $"{Hero.SpecialMove()} adds +{Hero.addAttack()}";
    }
}