using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    int damage = 25;
    BulletType type = BulletType.Slow;

    private void OnCollisionEnter(Collision collision)
    {
        IDamagable damagable = collision.gameObject.GetComponent<IDamagable>();
        if(damagable != null)
        {
            damagable.TakeDamage(type, damage);
            //damagable.TakeDamage(BulletModel.Damage, BulletModel.DamageType);
        }
    }
}
