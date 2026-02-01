using UnityEngine;

public class CardManager : MonoBehaviour
{
    public Card[] cards;
    public GameManager gameManager;

    void Start()
    {
        SetupCards();
        HideCards();
    }

    void SetupCards()
    {
        ActType[] acts = { ActType.Dancing, ActType.Singing, ActType.Acting };

        for (int i = 0; i < cards.Length; i++)
        {
            cards[i].Setup(gameManager, acts[i]);
        }
    }

    public void ShowCards()
    {
        foreach (Card card in cards)
            card.gameObject.SetActive(true);
    }

    public void HideCards()
    {
        foreach (Card card in cards)
            card.gameObject.SetActive(false);
    }
}
