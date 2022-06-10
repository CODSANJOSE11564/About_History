using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScript : MonoBehaviour
{
    public IEnumerator Disablescript(GameObject TypeOfAttack)
    {
        TypeOfAttack.SetActive(true);
        gameObject.GetComponent<AttackCode>().enabled = false;
        yield return new WaitForSeconds(TypeOfAttack.GetComponent<AttackStats>().TimeToRecharge);
        TypeOfAttack.SetActive(false);
        gameObject.GetComponent<AttackCode>().enabled = true;
    }
}
