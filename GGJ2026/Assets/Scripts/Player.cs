using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public AudienceMood audienceMood;
    public PlayerSpriteController spriteController;
    public EnemyController enemy;
    public LevelManager levelManager;

    public bool playerTurn = false;
    public ActType currentEnemyAct;


    public void OnEnemyActFinished(ActType enemyAct)
    {
        currentEnemyAct = enemyAct;
        playerTurn = true;
    }

    public void OnEnemyAct(ActType enemyAct)
    {
        Debug.Log("Enemy played: " + enemyAct);
    }


    public void OnCardChosen(ActType chosenAct)
    {
        if (!playerTurn) return;
        playerTurn = false;

        spriteController.PlayAct(chosenAct);

        if (chosenAct == currentEnemyAct)
        {
            audienceMood.increaseMood();
        }
        else
        {
            audienceMood.decreaseMood();
        }

        CheckTurnEndCondition();

    }

    public void OnPlayerTimeLost()
    {
        if (!playerTurn) return;
        playerTurn = false;
        audienceMood.decreaseMood();
        CheckTurnEndCondition();
    }

    void CheckTurnEndCondition()
    {
        if (audienceMood.currentMood == 0)
        {
            Debug.Log("LOSE");
            Time.timeScale = 0f;
        }
        else if (audienceMood.currentMood == 3)
        {
            Debug.Log("WIN");
            Time.timeScale = 0f;
        }
        else
        {
            levelManager.Update();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            OnCardChosen(ActType.Dancing);
            Debug.Log("D key pressed" );
        }
            

        if (Input.GetKeyDown(KeyCode.S))
        {
            OnCardChosen(ActType.Singing);
            Debug.Log("S key pressed" );
        }
            

        if (Input.GetKeyDown(KeyCode.P))
        {
            OnCardChosen(ActType.Acting);
            Debug.Log("P key pressed" );
        }
            
    }




}
