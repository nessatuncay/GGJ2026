using System;
using UnityEngine;

public class TimedEvents : MonoBehaviour
{
    // Variable to track time elapsed on a given lvl
    private float levelTimer;
    // Used to fire animations in the scene, if needed
    Animator anim;
    
    
    void Start()
    {
        // Initialize levelTimer with a value of 0
        levelTimer = 0;
        // Get an animator component from somewhere
        anim = FindAnyObjectByType<Animator>();
    }

    void FixedUpdate()
    {
        IncrementLevelTimer();
    }

    // Function to update levelTimer
    private void IncrementLevelTimer()
    {
        levelTimer += Time.deltaTime;
    }

    
}
