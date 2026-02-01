using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Menu_Main : MonoBehaviour
{
    // EXPERIMENTAL VARIABLES
    //Vector2 mousePointer;
    //bool mouseClick = false;

    Keyboard keyboard;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //mousePointer = VirtualMouseInput;

        // This initializes the connected Keyboard
        keyboard = InputSystem.GetDevice<Keyboard>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (keyboard.enterKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(1);

        }
        if(keyboard.escapeKey.wasPressedThisFrame)
        {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        // this half is needed to close the built application (keep in the regular if statement)
        #else
            Application.Quit();
        // we won't need this endif in the build version, either
        #endif
        }
    }
}
