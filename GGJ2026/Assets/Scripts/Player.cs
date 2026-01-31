using UnityEngine;

public class Player : MonoBehaviour
{
    public AudienceMood audienceMood;
    public PlayerAnimator playerAnimator;

    private ActType currentEnemyAct;
    private bool playerTurn = false;
    

    public void startPlayerTurn(ActType enemyAct)
    {
        currentEnemyAct = enemyAct;
        playerTurn = true;
    }





}
