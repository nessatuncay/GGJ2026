using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyController enemy;
    public CardManager cardManager;
    public TurnTimer turnTimer;
    public Player player;
    public LevelManager levelManager;

    public void StartTurn()
    {
        if (levelManager.IsTransitioning) return;

        ActType enemyAct = enemy.PlayRandomAct();
        player.OnEnemyActFinished(enemyAct);

        cardManager.ShowCards();
        turnTimer.StartTimer();
    }

    public void OnPlayerChoseCard(ActType act)
    {
        turnTimer.StopTimer();
        cardManager.HideCards();
        player.OnCardChosen(act);

        Invoke(nameof(StartTurn), 1.0f);
    }

    public void OnTimeOut()
    {
        cardManager.HideCards();
        player.OnPlayerTimeLost();

        Invoke(nameof(StartTurn), 1.0f);
    }
}
