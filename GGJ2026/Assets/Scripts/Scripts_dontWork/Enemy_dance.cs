/*using System.Collections.Generic;
using UnityEngine;

public class Enemy_dance : MonoBehaviour
{

    public int audienceMeter = 1; // 0–3
    public MatchState matchState = MatchState.Playing;

    public QuickTimeSystem qteSystem;

    void Start()
    {
        StartCoroutine(EnemyRhythmLoop());
    }

    System.Collections.IEnumerator EnemyRhythmLoop()
    {
        while (matchState == MatchState.Playing)
        {
            qteSystem.SpawnQTE();
            yield return new WaitForSeconds(1.2f); // rhythm speed
        }
    }

    public void OnQTEResult(QTEResult result)
    {
        if (result == QTEResult.Perfect)
            audienceMeter++;
        else if (result == QTEResult.Miss)
            audienceMeter--;

        audienceMeter = Mathf.Clamp(audienceMeter, 0, 3);

        if (audienceMeter >= 3)
            matchState = MatchState.PlayerWon;

        if (audienceMeter <= 0)
            matchState = MatchState.PlayerLost;
    }*/


    /*
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


    //public virtual void Start()
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
    
}*/
