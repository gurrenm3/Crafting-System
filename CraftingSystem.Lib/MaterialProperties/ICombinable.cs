namespace CraftingSystem.Lib.MaterialProperties
{
    public interface ICombinable<CombineType>
    {
        CombineType Combine(CombineType combinesWith);
    }

    public interface ICombinable<CombineType, Result>
    {
        Result Combine(CombineType combinesWith);
    }
}
