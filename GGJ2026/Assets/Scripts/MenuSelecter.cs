using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelecter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void playgame()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
    public void quit()
    {
        Application.Quit();
    }
}
