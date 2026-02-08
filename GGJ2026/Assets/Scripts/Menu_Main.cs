using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
public class Menu_Main : MonoBehaviour
{
    // Variables to initialize at Start()
    bool busy;
    Keyboard keyboard;
    protected AudioSource audioSource;
    protected Animator animator;

    void Start()
    {
        busy = false;
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        keyboard = InputSystem.GetDevice<Keyboard>();
    }
    void Update()
    {
        // Enter key does what clicking play does
        if (keyboard.enterKey.isPressed && !busy)
        {
            busy = true;
            Play();
        }

        // F4 will exit the game
        if(keyboard.f4Key.isPressed && !busy)
        {
            busy = true;
            Quit();
        }
    }
    protected void Play()
    {
        // Launch the game
        busy = true;
        Debug.Log("Loading Stage_01...");
        Invoke(nameof(NewGame), 1.5f);
    }
    public void NewGame()
    {
        busy = true;
        SceneManager.LoadSceneAsync(1);
    }
    
    // Darren B.
    // Quitting sequence
    public void Quit()
    {
        busy = true;
        Debug.Log("Farewell, and may we dance under these lights again!");
        Invoke(nameof(QuitApplcation), 1.5f);
    }
    void QuitApplcation()
    {
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    // Darren B.
    // Animator Instructions
    public void IntroFinished()
    {
        // Intro Animation Complete
        animator.SetBool("introBool", false);
        animator.SetBool("playBool", false);
        animator.SetBool("quitBool", false);
    }

    public void ResetSpotlight()
    {
        animator.SetBool("introBool", false);
        animator.SetBool("playBool", false);
        animator.SetBool("quitBool", false);
    }
    public void SpotlightPlay()
    {
        animator.SetBool("introBool", false);
        animator.SetBool("playBool", true);
        animator.SetBool("quitBool", false);
    }
    public void SpotlightQuit()
    {
        animator.SetBool("introBool", false);
        animator.SetBool("playBool", false);
        animator.SetBool("quitBool", true);
    }
}
