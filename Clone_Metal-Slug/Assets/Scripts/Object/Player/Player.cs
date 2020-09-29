using UnityEngine;

namespace Object.Player
{
    public class Player : Entity
    {
        private Rigidbody2D rigidbody;
        private readonly float jumpSize;
        private State<Weapon> currentWeapon;

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
            Destroy(gameObject);
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

        public void Spawn()
        {
            /*
             To-Do
             애니메이터에서 스폰 모션으로 바뀌도록 설정한다...
             */
        }
    }
}
