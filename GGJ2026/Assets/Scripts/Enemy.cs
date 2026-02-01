using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public EnemySpriteController spriteController;
    public Player player;

    public float delayBeforeAct = 1f;

    void Start()
    {
        StartCoroutine(EnemyTurnLoop());
    }

    IEnumerator EnemyTurnLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayBeforeAct);

            ActType chosenAct = GetRandomAct();

            spriteController.PlayAct(chosenAct);

            yield return new WaitForSeconds(1f); // wait for animation

            player.OnEnemyAct(chosenAct);

            yield return new WaitForSeconds(3f); // player reaction window
        }
    }

    ActType GetRandomAct()
    {
        return (ActType)Random.Range(0, 3);
    }
}
