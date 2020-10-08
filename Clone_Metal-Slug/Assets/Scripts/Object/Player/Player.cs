using UnityEngine;

namespace Object.Player
{
    public class Player : Entity
    {
        public int CountOfGrenade;
        
        private Rigidbody2D rigidbody;
        private Weapon currentWeapon;
        private Grenade currentGrenade;
        private bool isJumping = false;

        private static readonly float jumpSize = 50f;

        void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }
        
        void Update()
        {
            
        }
        
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
            direction = direction > 0 ? 1 : -1;
            
            transform.Translate(direction, 0, 0);
        }

        public override void Jump()
        {
            if (!isJumping)
            {
                rigidbody.AddForce(new Vector2(0, jumpSize));
            }
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
