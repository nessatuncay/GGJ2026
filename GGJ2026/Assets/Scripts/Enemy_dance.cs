using System.Collections.Generic;
using UnityEngine;

public class Enemy_dance : MonoBehaviour
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

    public List<Sprite> sprites;

    //dancing
    //public Sprite dancingSprite;

    //singing
    //public Sprite singingSprite;

    //acting
    // public Sprite actingSprite;

    //Sprite Randerer
    public SpriteRenderer spriteRenderer;

    //-----------------------------------------------------


    public virtual void Start()
    {
        StartMatch();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
                //spriteRenderer.sprite = dancingSprite;
                break;

            case ActType.Singing:
                //spriteRenderer.sprite = singingSprite;
                break;

            case ActType.Acting:
                //spriteRenderer.sprite = actingSprite;
                break;
        }
    }

}
