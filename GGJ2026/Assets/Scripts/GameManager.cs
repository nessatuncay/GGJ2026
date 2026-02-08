// using UnityEngine;
// using System.Collections;

// public class GameManager : MonoBehaviour
// {
//     public Enemy enemy;
//     public Player player;
//     public AudienceMood audienceMood;
//     public AudioManager audioManager;

//     public float enemyDelay = 1.5f;
//     public float reactionTime = 2f;

//     private ActType currentEnemyAct;
//     private bool waitingForPlayer = false;

//     void Start()
//     {
//         StartCoroutine(GameLoop());
//     }

//     IEnumerator GameLoop()
//     {
//         while (true)
//         {
//             // ENEMY TURN
//             Debug.Log("Start of Enemy Turn");
//             yield return new WaitForSeconds(enemyDelay);

//             currentEnemyAct = GetRandomAct();
//             Debug.Log($"Enemy's move: {currentEnemyAct}");
            
//             // Untested
//             //      enemy.PlayAct(currentEnemyAct);

//             // Crashing
//             //    audioManager.PlayEnemyActSound();

//             yield return new WaitForSeconds(1f); // enemy sprite duration

//             // PLAYER TURN
//             Debug.Log("Start of Player Turn");
//             waitingForPlayer = true;
//             //player.StartReactionWindow();

//             float timer = 0f;
//             while (waitingForPlayer && timer < reactionTime)
//             {
//                 timer += Time.deltaTime;
//                 yield return null;
//             }

//             if (waitingForPlayer)
//             {
//                 waitingForPlayer = false;
//                 player.OnPlayerTimeLost();
//                 audienceMood.decreaseMood();
//                 Debug.Log("Audience Mood Decreases");
//             }

//             yield return new WaitForSeconds(0.5f);
//         }
//     }

//     public void OnPlayerChoseAct(ActType act)
//     {
//         waitingForPlayer = false;

//         if (act == currentEnemyAct)
//         {
//             Debug.Log("Correct!");
//             audienceMood.increaseMood();
//         }
//         else
//         {
//             Debug.Log("Wrong!");
//             audienceMood.decreaseMood();
//         }
            
//     }

//     ActType GetRandomAct()
//     {
//         return (ActType)Random.Range(0, 3);
//     }
// }
