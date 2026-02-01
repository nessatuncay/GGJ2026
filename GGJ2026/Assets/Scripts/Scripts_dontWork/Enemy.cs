/*using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour

{

    //----------------------------------------------------
    //connect to enum ActType dance and singing and acting
    public ActType currentAct;

    //connect to enum MatchState
    public MatchState EndMatch;

    //connect to class player
    public Player player;

    //----------------------------------------------------



    //each different sprite that will be randomazied 

    //dancing
    public Sprite dancingSprite;

    //singing
    public Sprite singingSprite;

    //acting
    public Sprite actingSprite;

    //Sprite Randerer
    public SpriteRenderer spriteRenderer;

    //-----------------------------------------------------


    public virtual void Start()
    {
        StartMatch();
    }

    public void StartMatch()
    {
        ChooseRandomAct();
        ApplyActSprite();
    }

    public void ChooseRandomAct()
    {
        currentAct = (ActType)Random.Range(
            0,
            System.Enum.GetValues(typeof(ActType)).Length
        );
    }

    public void ApplyActSprite()
    {
        switch (currentAct)
        {
            case ActType.Dancing:
                spriteRenderer.sprite = dancingSprite;
                break;

            case ActType.Singing:
                spriteRenderer.sprite = singingSprite;
                break;

            case ActType.Acting:
                spriteRenderer.sprite = actingSprite;
                break;
        }
    }
}*/







