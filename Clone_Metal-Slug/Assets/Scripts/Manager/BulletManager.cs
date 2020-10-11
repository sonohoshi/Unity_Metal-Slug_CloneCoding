using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BulletManager
{
    /*
    BulletType에는 이전에 만든 프로젝트에서 쓰던걸 가져왔다.
    어떤 프리팹을 이용할 것인지 해당 enum을 이용해 관리할 것이다.
     */
    public enum BulletType : int { Base = 0, Silver = 1, BaseVolt = 2, SilverVolt = 3 }
    public class BulletInfo
    {
        public Transform Bullet { get; set; }
        public BulletType ImageType { get; set; }
        public float LiveTime { get; set; }
    }

    /*
     return할 url형 string에는 해당 총알의 프리팹 위치를 전달한다.
     */
    public static string BulletTypeToPath(BulletType type)
    {
        switch (type)
        {
            case BulletType.Base: return @"BulletPrefabs/BaseBullet";
            case BulletType.Silver: return @"BulletPrefabs/SilverBullet";
            case BulletType.BaseVolt: return @"BulletPrefabs/BaseVolt";
            case BulletType.SilverVolt: return @"BulletPrefabs/SilverVolt";
        }

        throw new System.NullReferenceException();
    }
    
    public static float GetBulletDamage(BulletType type)
    {
        switch (type)
        {
            case BulletType.Base: return 0;
            case BulletType.Silver: return 0;
            case BulletType.BaseVolt: return 0;
            case BulletType.SilverVolt: return 0;
        }

        throw new System.NullReferenceException();
    }
}