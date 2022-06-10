using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _health = 20;
    [SerializeField] private GameObject SceneManager = default;
    [SerializeField] private bool _isInmune = default;
    void Update()
    {
        if (_health <= 0)
        { 
            GetComponent<AttackCode>().enabled = false;
            GetComponent<PlayerMovement>().enabled = false;
            SceneManager.GetComponent<HealthManager>().Youlost();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entro");
        if (other.CompareTag("NPCATTACK") && !_isInmune)
        {
            StartCoroutine(ReduceHealth(other.GetComponent<AttackStats>().TypeOfAttack, other.GetComponent<AttackStats>().DamageToGive));
        }
    }

    private IEnumerator ReduceHealth(float TypeOfattack, float DamageToGive)
    {
        _health -= DamageToGive;
        var StringParameter = TypeOfattack == 0 ? "RecibirPatada" : "RecibirGolpe";
        _isInmune = true;
        StartCoroutine(GetComponent<AnimationManager>().HittedAnimtion(StringParameter));
        GetComponent<AttackCode>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(1.4f);
        GetComponent<AttackCode>().enabled = true;
        GetComponent<PlayerMovement>().enabled = true;
        _isInmune = false;
    }
}
