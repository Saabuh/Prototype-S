using UnityEngine;

namespace Prototype_S
{
    public class Inventory : ScriptableObject
    {
        public ItemContainer itemContainer { get; } = new ItemContainer(20);

    }
}