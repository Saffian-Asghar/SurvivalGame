using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITakeDamage 
{

    void TakeDamage(Weapon weapon, Projectiles projectile, Vector3 contactPoint);

}
