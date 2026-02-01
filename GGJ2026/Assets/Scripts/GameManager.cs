using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Enemy enemy;
    public Player player;

    public float enemyDelay = 1f;
    public float reactionTime = 2f;

    private ActType currentEnemyAct;
    private bool waitingForPlayer = false;

    void Start()
    {
        StartCoroutine(GameLoop());
    }

    IEnumerator GameLoop()
    {
        while (true)
        {
            // ENEMY TURN
            yield return new WaitForSeconds(enemyDelay);

            currentEnemyAct = GetRandomAct();
            enemy.PlayAct(currentEnemyAct);

            yield return new WaitForSeconds(1f); // enemy sprite duration

            // PLAYER TURN
            waitingForPlayer = true;
            player.StartReactionWindow();

            float timer = 0f;
            while (waitingForPlayer && timer < reactionTime)
            {
                timer += Time.deltaTime;
                yield return null;
            }

            if (waitingForPlayer)
            {
                waitingForPlayer = false;
                player.OnTimeout();
                Debug.Log("Player failed");
            }

            yield return new WaitForSeconds(0.5f);
        }
    }

    public void OnPlayerChoseAct(ActType act)
    {
        waitingForPlayer = false;

        if (act == currentEnemyAct)
            Debug.Log("Correct!");
        else
            Debug.Log("Wrong!");
    }

    ActType GetRandomAct()
    {
        return (ActType)Random.Range(0, 3);
    }
}
