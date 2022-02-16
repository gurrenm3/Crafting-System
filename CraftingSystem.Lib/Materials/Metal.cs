using CraftingSystem.Lib.MaterialProperties;

namespace CraftingSystem.Lib.Materials
{
    /// <summary>
    /// This class represents the funcionality of any metal.
    /// </summary>
    public class Metal : ICombinable<Metal, Alloy>, IMeltable, ICraftMaterial
    {
        public double Weight { get; set; }
        public double MeltingPoint { get; set; }
        public double CurrentTemperature { get; set; }


        public Alloy Combine(Metal combinesWith)
        {
            return Alloy.CreateFrom(this, combinesWith);
        }
    }
}
