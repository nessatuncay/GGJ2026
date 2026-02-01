using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator;

    public void PlayActAnimation(ActType act)
    {
        animator.SetTrigger(act.ToString());
    }

    
}
