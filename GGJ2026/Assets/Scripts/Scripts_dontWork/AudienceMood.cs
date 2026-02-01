
using UnityEngine;
using UnityEngine.UI;

public class AudienceMood : MonoBehaviour
{
    
    public int maxMood = 200;
    public int startMood = 10;
    public int currentMood;

    public Slider moodSlider;

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
    }

    public void decreaseMood()
    {
        currentMood = Mathf.Clamp(currentMood - 1, 0, maxMood);
        moodSlider.value = currentMood;
    }

        
    


}
