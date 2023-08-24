using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile Ability", menuName = "Ability/new Projectile Ability")]
public class ProjectileAbility : Ability
{
    public GameObject projectile;
    public override void Use(GameObject caster)
    {
        base.Use(caster);

        if (projectile != null)
        {
            Instantiate(projectile, caster.transform.position, Quaternion.identity);
        }
    }
}
