using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int audienceMood;
        int cardAmount;
        bool hasWon;
        bool hasLost;
    }

    // Update is called once per frame
    void Update()
    {
        Player player = GetComponent<Player>();
        int audienceMood = 2;

        if (audienceMood == 3)
        {
            bool hasWon = true;
        }
        else if(audienceMood == 0)
        {
            bool hasLost = true;
        }
    }
}
