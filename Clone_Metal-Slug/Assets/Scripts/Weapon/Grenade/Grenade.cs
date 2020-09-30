using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Grenades
{
    Bomb = 0,
    Fire = 1,
    Stone = 2
}

public class Grenade : MonoBehaviour
{
    public Grenades GrenadeType;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public override bool Equals(object other)
    {
        var otherGrenade = other as Grenade;
        if (otherGrenade != null)
        {
            return otherGrenade.GrenadeType == GrenadeType;
        }
        return false;
    }
}
