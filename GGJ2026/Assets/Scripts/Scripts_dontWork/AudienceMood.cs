
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudienceMood : MonoBehaviour
{
    
    public int maxMood = 200;
    public int startMood = 10;
    public int currentMood;

    public Slider moodSlider;

    public string winSceneName = "WinScene"; 
    public string loseSceneName = "LoseScene";

    void Start()
    {
        currentMood = startMood;
        moodSlider.maxValue = maxMood;
        moodSlider.value = currentMood;
    }

    public void increaseMood()
    {
        currentMood = Mathf.Clamp(currentMood + 1, 0, maxMood);
        moodSlider.value = currentMood;

        if (currentMood >= maxMood) // Check for win
        {
            PlayerWon();
        }
    }

    public void decreaseMood()
    {
        currentMood = Mathf.Clamp(currentMood - 1, 0, maxMood);
        moodSlider.value = currentMood;

        if (currentMood <= 0) // Check for loss
        {
            PlayerLost();
        }
    }

    void PlayerWon()
    {
        SceneManager.LoadScene(winSceneName);
    }

    void PlayerLost()
    {
        SceneManager.LoadScene(loseSceneName);
    }





}
