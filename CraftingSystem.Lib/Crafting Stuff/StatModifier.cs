namespace CraftingSystem.Lib
{
    public class StatModifier : Behavior
    {
        public List<Action<double>> onValueChanged = new List<Action<double>>();
        public StatType type;
        private double amount;

        public double GetAmount()
        {
            return amount;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
            onValueChanged.ForEach(action => action.Invoke(GetAmount()));
        }
    }
}
