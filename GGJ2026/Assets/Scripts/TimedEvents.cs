using System;
using System.Collections.Generic;
using UnityEngine;

public class TimedEvents : MonoBehaviour
{
    // Variables to track time elapsed
    public float levelTimer, roundTimer, flickerTimer, intermissionTimer;

    // Can be used as a multiplier of the passage of time being incremented to flickerTime
    public float flickerRate = 1.0f;

    public bool isPaused = false;

    Player player;
    Enemy enemy;
    // Used to fire animations in the scene, if needed
    Animator anim;
    
    
    void Start()
    {
        // Initialize levelTimer with a value of 0
        levelTimer = 0;
        // Get an animator component from somewhere
        anim = FindAnyObjectByType<Animator>();
        enemy = FindAnyObjectByType<Enemy>();
        player = FindAnyObjectByType<Player>();
    }

    void FixedUpdate()
    {
        if(!isPaused)
        {
            IncrementTimers();
        }
    }

    void Update()
    {
        
    }

    // Function to increment all timers by time since last increment
    private void IncrementTimers()
    {
        flickerTimer += Time.deltaTime * flickerRate;
        levelTimer += Time.deltaTime;
        roundTimer += Time.deltaTime;
        intermissionTimer += Time.deltaTime;
    }
    public void StartRound()
    {
        roundTimer = 0;
        enemy.ChooseRandomAct();
    }
    public void FlickerSpotlight()
    {
        // play the light-flickering animation
        anim.Play("Flicker");
    }
    public void EndRound()
    {
        
    }    
}
