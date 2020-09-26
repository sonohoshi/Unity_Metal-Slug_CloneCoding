using UnityEngine;

namespace Object.Player
{
    public class Player : Entity
    {
        private Rigidbody2D rigidbody;
        private readonly float jumpSize;

        protected override void Attack()
        {
            throw new System.NotImplementedException();
        }

        protected override void ThrowGrenade()
        {
            throw new System.NotImplementedException();
        }

        protected override void Dead()
        {
            throw new System.NotImplementedException();
        }

        public override void Move(float direction)
        {
            transform.Translate(direction, 0, 0);
        }

        public override void Jump()
        {
            rigidbody.AddForce(new Vector2(0, jumpSize));
        }

        public override bool Damaged(int attackDamage)
        {
            healthPoint -= attackDamage;
            if (healthPoint <= 0)
            {
                Dead();
                return true;
            }

            return false;
        }
    }
}
