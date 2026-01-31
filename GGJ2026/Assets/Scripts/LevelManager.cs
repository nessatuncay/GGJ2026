using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public int maxLevel = 3;
    public int currentLevel = 1;

    public bool transitioning = false;

    public AudienceMood audienceMood;

    public void Update()
    {
        if (transitioning) return;

        if (audienceMood.currentMood == 3)
        {
            StartCoroutine(LevelTransition());
        }
    }

    public IEnumerator LevelTransition()
    {
        transitioning = true;

        Debug.Log("Level " + currentLevel + " complete!");

        if (currentLevel >= maxLevel)
        {
            WinGame();
            yield break;
        }

        currentLevel++;
        SetupNextLevel();
        transitioning = false;
    }

    void SetupNextLevel()
    {
        audienceMood.currentMood = audienceMood.startMood;
        audienceMood.moodSlider.value = audienceMood.currentMood;
        Debug.Log("Starting Level " + currentLevel);
    }

    void WinGame()
    {
        Debug.Log("ALL LEVELS COMPLETE — YOU WIN!");
        Time.timeScale = 0f;
    }
}
