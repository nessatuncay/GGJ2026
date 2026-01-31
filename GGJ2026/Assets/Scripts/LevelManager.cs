using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int maxLevel = 3;
    public int currentLevel = 1;

    public bool levelComplete = false;

    public AudienceMood audienceMood;

    void Update()
    {
        if (levelComplete) return;

        if (audienceMood.currentMood == 3)
        {
            levelComplete = true;
            GoToNextLevel();
        }
    }

    void GoToNextLevel()
    {

    }
}
