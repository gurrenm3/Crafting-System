using CraftingSystem.Lib.CraftingSystem;
using CraftingSystem.Lib.MaterialProperties;

namespace CraftingSystem.Lib.Items
{
    public class Weapon : IBreakable, ICraftable
    {
        public double Damage { get; set; }
        public double CurrentDamage { get; set; }
        public double BreakingPoint { get; set; }

        public Weapon()
        {

        }

        public virtual CraftRecipe GetRecipe()
        {
            throw new NotImplementedException();
        }
    }
}
