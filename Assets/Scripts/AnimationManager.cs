
using System.Collections;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator animator = default;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimationsKick(string StringParameter)
    {
        animator.SetTrigger(StringParameter);
    }

    public void AnimationsFist(string StringParameter)
    {
        animator.SetTrigger(StringParameter);
    }

    public void JokeAnimation()
    {
        animator.SetTrigger("Burla");
    }

    public IEnumerator HittedAnimtion(string StringParameter)
    {
        yield return new WaitForSeconds(.6f);
        animator.SetTrigger(StringParameter);
    }
    public void DeathAnimation()
    {
        animator.SetTrigger("Muerte");
    }
}
