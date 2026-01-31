using System.Collections.Generic;
using UnityEngine;

public class CardsDataBase : MonoBehaviour
{

   public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Card 1", "Description 1", "Singing"));
        cardList.Add(new Card(1, "Card 1", "Description 1", "Acting"));
        cardList.Add(new Card(2, "Card 1", "Description 1", "Dancing"));
    }
}
