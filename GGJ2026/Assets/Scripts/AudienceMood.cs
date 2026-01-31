
using UnityEngine;
using UnityEngine.UI;

public class AudienceMood : MonoBehaviour
{
    
    int maxMood = 3;
    int startMood = 1;
    int currentMood;

    Slider moodSlider;

    void gameStart()
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
