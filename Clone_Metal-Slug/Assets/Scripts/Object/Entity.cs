using UnityEngine;

namespace Object
{
    public abstract class Entity : MonoBehaviour
    {
        protected int healthPoint;

        protected abstract void Attack();
        protected abstract void ThrowGrenade();
        protected abstract void Dead();
        public abstract void Move(float direction);
        public abstract void Jump();
        public abstract bool Damaged(int attackDamage);
    }
}
