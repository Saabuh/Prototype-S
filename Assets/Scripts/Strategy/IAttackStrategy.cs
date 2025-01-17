using UnityEngine;

namespace Prototype_S
{
    /// <summary>
    /// Interface that defines how an attack behaves.
    /// </summary>
    /// <para>
    /// Each concrete implementation of IAttackStrategy defines how an attack behaves before instantiation.
    /// </para>
    public interface IAttackStrategy
    {
        void ExecuteAttack(Transform origin);
    }
}