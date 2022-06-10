using System;
using UnityEngine;

public class HittlerHealth : MonoBehaviour
{
    [SerializeField] private float _health = 20;

    private void Update()
    {
        if (_health <= 0)
        {
           GetComponent<AnimationManager>().DeathAnimation();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Attack"))
        { 
            ReduceHealth(other.GetComponent<AttackStats>().DamageToGive, other.GetComponent<AttackStats>().TypeOfAttack); 
        }
        Debug.Log(_health);
    }
    private void ReduceHealth(float Damage, float TypeOfAttack)
    {
        _health -= Damage;
        var StringParameter = TypeOfAttack > 0 ? "RecibirPatada" : "RecibirGolpe";
        StartCoroutine(GetComponent<AnimationManager>().HittedAnimtion(StringParameter));
    }
}
