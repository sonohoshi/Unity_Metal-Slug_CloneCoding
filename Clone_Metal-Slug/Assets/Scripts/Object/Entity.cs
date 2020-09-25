using UnityEngine;

namespace Object
{
    public interface IEntity
    {
        void Attack();
        bool Damaged(int attackDamage);
        void Dead();
        void Move(float direction);
        void Jump();
        void ThrowGrenade();
    }
    
    public class Entity : MonoBehaviour, IEntity
    {
        protected int healthPoint;

        void IEntity.Attack() { }
        void IEntity.ThrowGrenade() { }
        bool IEntity.Damaged(int attackDamage) { return true; }
        void IEntity.Dead() { }
        void IEntity.Move(float direction) { }
        void IEntity.Jump() { }
    }
}
