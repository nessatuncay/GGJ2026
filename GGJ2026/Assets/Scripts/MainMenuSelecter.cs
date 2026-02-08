using UnityEngine;

public class MainMenuSelecter : Menu_Main
{   
    public Animator ani;
    void Awake()
    {
        Debug.Log("Menu Buttons are awake");
    }
    public void Playgame()
    {
        Debug.Log("Clicked Play");
        Play();
    }
    public void Quitgame()
    {
        Debug.Log("Clicked Exit");
        Quit();
    }
    public void MousePointPlay()
    {
        Debug.Log("Moused Over Play");
        //SpotlightPlay();
        ani.SetBool("playBool",true);
    }
    public void MousePointQuit()
    {
        Debug.Log("Moused Over Play");
        SpotlightQuit();
    }
    public void MousePointNone()
    {
        Debug.Log("Moused Over Play");
        ResetSpotlight();
    }
    
}
