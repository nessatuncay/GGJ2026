/*using UnityEngine;

public class Player_dance : MonoBehaviour
{

    public int score;
    public int combo;

    public QuickTimeSystem qteSystem;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            qteSystem.CheckInput();
        }
    }

    public void OnQTEResult(QTEResult result)
    {
        if (result == QTEResult.Perfect)
        {
            combo++;
            score += 100;
        }
        else if (result == QTEResult.Good)
        {
            combo++;
            score += 50;
        }
        else
        {
            combo = 0;
        }
    }

}*/
