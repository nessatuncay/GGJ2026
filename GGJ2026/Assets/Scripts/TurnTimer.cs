using UnityEngine;
using System.Collections;

public class TurnTimer : MonoBehaviour
{
    public float timeLimit = 3f;
    private Coroutine timerRoutine;
    private GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void StartTimer()
    {
        StopTimer();
        timerRoutine = StartCoroutine(Timer());
    }

    public void StopTimer()
    {
        if (timerRoutine != null)
            StopCoroutine(timerRoutine);
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(timeLimit);
        gameManager.OnTimeOut();
    }
}
