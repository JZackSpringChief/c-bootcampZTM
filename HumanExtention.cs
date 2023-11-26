

public static class HumanExtentions
{
    public static string WeaponAndAttackPower(this Human Hero)
    {
        return $"{Hero.SpecialMove()} adds +{Hero.addAttack()}";
    }
}
public static class PhysicalUnitExtention
{
    public static bool IsPhysical(this IPhysicalUnit physicalUnit)
    {
        return physicalUnit.IsPhysical == "true";
    }
}