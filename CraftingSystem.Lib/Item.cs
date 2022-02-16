namespace CraftingSystem.Lib
{
    public class Item : BehaviorOwner
    {
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }

        private int quantity;

        public Item()
        {

        }

        public Item(string name, int quantity)
        {
            Name = name;
            FriendlyName = name;
            SetQuantity(quantity);
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void RaiseQuantity(int amountToRaise)
        {
            SetQuantity(GetQuantity() + amountToRaise);
        }

        public void ReduceQuantity(int amountToRemove)
        {
            SetQuantity(GetQuantity() - amountToRemove);
        }

        public void SetQuantity(int amountToSet, bool canGoNegative = false)
        {
            quantity = amountToSet;

            if (!canGoNegative && quantity < 0)
                quantity = 0;            
        }
    }
}
