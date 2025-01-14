using System.Text;
using UnityEditor;
using UnityEngine;

namespace Prototype_S
{
    public class Weapon : Item, IUseable

    {
        public override string GetItemDisplayText()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(Name).AppendLine();
            builder.Append("Max Stack: ").Append(MaxStack).AppendLine();
            builder.Append("Sell Price: ").Append(SellPrice).Append(" Gold");

            return builder.ToString();
        }

        public void Use()
        {
            Debug.Log("Weapon has been used.");
        }
    }
}