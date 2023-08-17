using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile Ability", menuName = "Create new Projectile Ability")]
public class ProjectileAbility : Ability
{
    public GameObject projectile;
    public override void Use(GameObject caster)
    {
        Debug.Log($"Ability [{name}] has been used");
        if (projectile != null)
        {
            Instantiate(projectile, caster.transform.position, Quaternion.identity);
        }
    }
}
