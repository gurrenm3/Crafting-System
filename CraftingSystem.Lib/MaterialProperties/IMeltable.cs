namespace CraftingSystem.Lib.MaterialProperties
{
    public interface IMeltable : IHeatable
    {
        double MeltingPoint { get; set; }
    }
}
