
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class NPCAttack : MonoBehaviour
{
    [SerializeField] private GameObject _hitlerfist = default;
    [SerializeField] private GameObject _hitlerKick = default;
    [SerializeField] private float timer = default;
    [SerializeField] private float _maxTimer = 5;
    [SerializeField] private float RandomState = default;
    [SerializeField] private AudioSource _audioSource = default;
    [SerializeField] private AudioClip[] _audioClips = default;
    void Update()
    {
        RandomAttacks();
        timer += Time.deltaTime;
    }


    private void RandomAttacks()
    {
        if (timer >= _maxTimer)
        {
            RandomState = Random.Range(0, 2);
            if (RandomState == 0)
            {
                GetComponent<AnimationManager>().AnimationsFist("Golpe");
                _audioSource.PlayOneShot(_audioClips[0],.3f);
                StartCoroutine(ActivateColliders(RandomState));
                _maxTimer = Random.Range(5, 8);
            }
            else if (RandomState == 1 )
            {
                GetComponent<AnimationManager>().AnimationsKick("Patada");
                _audioSource.PlayOneShot(_audioClips[1],.3f);
                StartCoroutine(ActivateColliders(RandomState));
                _maxTimer = Random.Range(5, 8);
            }
            timer = 0;
        }
    }

    private IEnumerator ActivateColliders(float RandomState)
    {
        if(RandomState == 0)
        {
            _hitlerfist.SetActive(true);
            yield return new WaitForSeconds(1.7f);
            _hitlerfist.SetActive(false);
        }
        else if (RandomState == 1)
        {
            _hitlerKick.SetActive(true);
            yield return new WaitForSeconds(1.6f);
            _hitlerKick.SetActive(false);
        }
    }
}
