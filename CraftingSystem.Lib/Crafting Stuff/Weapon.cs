namespace CraftingSystem.Lib
{
    public class Weapon : Item
    {
        public Weapon()
        {
            
        }

        public double GetStatValue(StatType statToGet)
        {
            double totalValue = 0;
            GetStatModifiers(statToGet).ForEach(stat =>
            {
                totalValue += stat.GetAmount();
            });
            return totalValue;
        }

        private List<StatModifier> GetStatModifiers()
        {
            return GetBehaviors<StatModifier>(recursive: true);
        }

        private List<StatModifier> GetStatModifiers(StatType typeToGet)
        {
            return GetStatModifiers().FindAll(s => s.type == typeToGet);
        }
    }
}
