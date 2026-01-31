
using UnityEngine;
using UnityEngine.UI;

public class AudienceMood : MonoBehaviour
{
    
    public int maxMood = 3;
    public int startMood = 1;
    public int currentMood;

    public Slider moodSlider;

    void GameStart()
    {
        currentMood = startMood;
        moodSlider.maxValue = maxMood;
        moodSlider.value = currentMood;
    }

    public void increaseMood()
    {
        currentMood = Mathf.Clamp(currentMood + 1, 0, maxMood);
        moodSlider.value = currentMood;
    }

    public void decreaseMood()
    {
        currentMood = Mathf.Clamp(currentMood - 1, 0, maxMood);
        moodSlider.value = currentMood;
    }

        
    


}
