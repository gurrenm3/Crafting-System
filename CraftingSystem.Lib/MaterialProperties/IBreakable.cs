namespace CraftingSystem.Lib.MaterialProperties
{
    public interface IBreakable
    {
        double CurrentDamage { get; set; }
        double BreakingPoint { get; set; }
    }
}
