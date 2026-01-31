using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyDamage = 1;

    //public int enemyType;

    public Sprite[] enemyPoses;

    public SpriteRenderer spriteRenderer;


    protected int currentPoseIndex = -1;

    protected virtual void Start()

    {
        StartMatch();
    }

    protected void StartMatch()
    {
        ChooseRandomPose();
    }


    protected void ChooseRandomPose()
    {
        int newPose;

        do
        {
            newPose = Random.Range(0, enemyPoses.Length);
        }
        while (newPose == currentPoseIndex && enemyPoses.Length > 1);

        currentPoseIndex = newPose;
        spriteRenderer.sprite = enemyPoses[currentPoseIndex];
    }


}





