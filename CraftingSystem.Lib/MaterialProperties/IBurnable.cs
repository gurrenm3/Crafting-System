namespace CraftingSystem.Lib.MaterialProperties
{
    public interface IBurnable : IHeatable
    {
        double BurningTemp { get; set; }
    }
}
