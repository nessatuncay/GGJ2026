using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;

    public ActType PlayRandomAct()
    {
        ActType act = (ActType)Random.Range(0, 3);
        animator.SetTrigger(act.ToString());
        return act;
    }
}
