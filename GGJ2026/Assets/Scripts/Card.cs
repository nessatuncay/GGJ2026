using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public ActType actType;
    private GameManager gameManager;

    public void Setup(GameManager manager, ActType act)
    {
        gameManager = manager;
        actType = act;
    }

    public void OnClick()
    {
        gameManager.OnPlayerChoseCard(actType);
    }
}
