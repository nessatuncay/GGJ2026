using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteController spriteController;

    private bool canInput = false;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void StartReactionWindow()
    {
        canInput = true;
    }

    void Update()
    {
        if (!canInput) return;

        if (Input.GetKeyDown(KeyCode.D))
            SubmitChoice(ActType.Dancing);

        if (Input.GetKeyDown(KeyCode.S))
            SubmitChoice(ActType.Singing);

        if (Input.GetKeyDown(KeyCode.A))
            SubmitChoice(ActType.Acting);
    }

    void SubmitChoice(ActType act)
    {
        canInput = false;
        spriteController.PlayAct(act);
        gameManager.OnPlayerChoseAct(act);
    }

    public void OnTimeout()
    {
        canInput = false;
        Debug.Log("Player missed input");
    }
}
