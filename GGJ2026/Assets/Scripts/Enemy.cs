using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyDamage = 1;

    public int enemyType;

    public Sprite[] enemyPoses =
        {
                "poseOne.png",
                "poseTwo.png",
                "poseThree.png"
            };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        //enemy and player win and lose condition
        Enemy enemyOne = GetComponent<Enemy>();
       

        if (!playerLose)
        {
            enemyOne.enemyDamage -= currentMood;
            if (enemyOne.enemyDamage < 0)
                enemyOne.enemyDamage = 0;
        }

        if (playerWon)
        {
           currentMood +=1 ;
        }
    }//end

    public class enemyOne()
    {

    }



// Update is called once per frame
void Update()
    {
        
    }
}





