
using UnityEngine;

public class AttackStats : MonoBehaviour
{
    [SerializeField] private float _damageToGive = 0;
    [SerializeField] private float _timeToRecharge = 0;
    [SerializeField] private float _typeOfAttack = 0;

    public float DamageToGive => _damageToGive;
    public float TimeToRecharge => _timeToRecharge;

    public float TypeOfAttack => _typeOfAttack;
}
