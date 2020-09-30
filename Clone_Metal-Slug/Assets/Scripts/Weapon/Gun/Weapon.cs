using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Weapons
{
    Handgun = 0,
    HeavyMachineGun = 1
}

public abstract class Weapon : MonoBehaviour
{
    protected int baseBulletCount;
    protected int bulletDamage;
    protected float maxFireDelay;
    protected float currentDelay;
    
    public Weapons WeaponType;

    public virtual bool Fire()
    {
        return CheckCanFire();
    }
    
    public override bool Equals(object other)
    {
        var otherWeapon = other as Weapon;
        if (otherWeapon != null)
        {
            return otherWeapon.WeaponType == WeaponType;
        }
        return false;
    }

    protected virtual bool CheckCanFire()
    {
        /*
         To-Do
         각 총 별로 애니메이션이 있다. 해당 애니메이션이 끝나면 총을 쏠 수 있는 것으로 간주한다.
         앉아있는 상태일 경우, 애니메이션 재생을 취소하고 공격을 할 수 있다.
         */
        return true;
    }
}
