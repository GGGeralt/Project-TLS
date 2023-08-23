using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Summon Ability", menuName = "Ability/new Summon Ability")]
public class SummonAbility : Ability
{
    [SerializeField] Creature summonCreature;
    public override void Use(GameObject caster)
    {
        base.Use(caster);

        Instantiate(summonCreature, Random.onUnitSphere * 3 + caster.transform.position, Quaternion.identity);
    }
}
