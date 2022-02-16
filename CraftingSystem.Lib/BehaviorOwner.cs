namespace CraftingSystem.Lib
{
    public class BehaviorOwner : Behavior
    {
        public string name;
        List<Behavior> behaviors = new List<Behavior>();

        public BehaviorOwner()
        {
            
        }


        #region Add Behaviors

        public virtual T AddBehavior<T>(T behavior) where T : Behavior
        {
            behaviors.Add(behavior);
            return behavior;
        }

        public virtual T AddBehavior<T>() where T : Behavior, new()
        {
            var behavior = new T();
            behaviors.Add(behavior);
            return behavior;
        }

        public virtual T AddBehavior<T>(params object[] args) where T : Behavior
        {
            T behavior = (T)Activator.CreateInstance(typeof(T), args);
            if (behavior is null)
                return null;

            behaviors.Add(behavior);
            return behavior;
        }

        #endregion


        #region Has Behaviors

        public bool HasBehaviors()
        {
            return behaviors.Any();
        }

        public bool HasBehavior<T>() where T : Behavior
        {
            var typeToGet = typeof(T);
            return behaviors.Any(b => b.GetType() == typeToGet);
        }

        public bool HasBehavior<T>(out T behavior) where T : Behavior
        {
            return (behavior = GetBehavior<T>()) != null;
        }

        #endregion


        #region Remove Behaviors

        public virtual bool RemoveBehavior(int indexToRemove)
        {
            if (indexToRemove > behaviors.Count)
                return false;

            behaviors.RemoveAt(indexToRemove);
            return true;
        }

        public virtual bool RemoveBehavior<T>() where T : Behavior
        {
            return RemoveBehavior(GetBehavior<T>());
        }

        public virtual bool RemoveBehavior(Behavior behaviorToRemove)
        {
            return behaviors.Remove(behaviorToRemove);
        }

        public virtual void RemoveBehaviors<T>() where T : Behavior
        {
            var typeToRemove = typeof(T);
            behaviors.RemoveAll(b => b.GetType() == typeToRemove);
        }

        #endregion        


        #region Get Behaviors

        public List<Behavior> GetBehaviors()
        {
            return GetBehaviors<Behavior>();
        }

        public Behavior GetBehavior(int index)
        {
            return (index > behaviors.Count) ? null : behaviors[index];
        }

        public T GetBehavior<T>() where T : Behavior
        {
            var typeToGet = typeof(T);
            return (T)behaviors.FirstOrDefault(b => b.GetType() == typeToGet);
        }

        public List<T> GetBehaviors<T>(bool recursive = false) where T : Behavior
        {
            if (recursive)
                return GetBehaviorsRecursive<T>();

            var typeToGet = typeof(T);
            List<T> results = new List<T>();

            behaviors.ForEach(b =>
            {
                if (b.GetType() == typeToGet)
                    results.Add((T)b);
            });

            return results;
        }

        private List<T> GetBehaviorsRecursive<T>() where T : Behavior
        {
            List<T> behaviors = new List<T>();
            foreach (var behavior in this.behaviors)
            {
                GetBehaviorsRecursive(behavior)?.ForEach(b =>
                {
                    behaviors.Add((T)b);
                });
            }

            return behaviors;
        }

        private List<T> GetBehaviorsRecursive<T>(T behavior) where T : Behavior
        {
            List<T> behaviors = new List<T>();

            // This is a behaviorOwner. Check all of it's behaviors for T
            if (behavior is BehaviorOwner behaviorOwner && behaviorOwner.HasBehaviors())
            {
                behaviorOwner.behaviors.ForEach(b =>
                {
                    GetBehaviorsRecursive(b).ForEach(beh =>
                    {
                        if (beh is T goodBehavior)
                        {
                            behaviors.Add(goodBehavior);
                        }
                    });
                });                
            }
            else if (behavior is T)
            {
                behaviors.Add(behavior); // This is what we want
            }

            return behaviors;
        }

        #endregion
    }
}
