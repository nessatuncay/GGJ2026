using UnityEngine;

  public class Player : MonoBehaviour
  {
//       public AudienceMood audienceMood;
//       public PlayerAnimator playerAnimator;
//       public ActType currentEnemyAct;
//       public bool playerTurn = false;
    

//         public void StartPlayerTurn(ActType enemyAct)
//         {
//             currentEnemyAct = enemyAct;
//             playerTurn = true;
//         }
//         public void OnCardChosen(ActType chosenAct)
//         {
//             if (!playerTurn) return;
            
//             playerTurn = false;
//             playerAnimator.PlayerActionAnimator(chosenAct);
//             if (chosenAct == currentEnemyAct)
//             {
//                 audienceMood.increaseMood();
//             }
//             else
//             {
//                 audienceMood.decreaseMood();
//             }
//             CheckTurnEndCondition();
//       }
//       public void OnPlayerTimeLost()
//       {
//             if (!playerTurn) return;
//             playerTurn = false;
//             audienceMood.decreaseMood();
//             CheckTurnEndCondition();
//       }
//       void CheckTurnEndCondition()
//       {
//           if (audienceMood.currentMood == 0)
//           {
//               Debug.Log("LOSE");
//               Time.timeScale = 0f;
//           }
//           else if (audienceMood.currentMood == 3)
//           {
//               Debug.Log("WIN");
//               Time.timeScale = 0f;
//           }
//       }
  }

