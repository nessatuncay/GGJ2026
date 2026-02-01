using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public EnemySpriteController spriteController;

    public void PlayAct(ActType act)
    {
        spriteController.PlayAct(act);
    }
}
