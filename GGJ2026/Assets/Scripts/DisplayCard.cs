using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId; //refers to the Card's ID

    public int Id; 
    public string cardName;
    public string cardDescription;
    public string cardType;

    public Text nameText; 
    public Text descriptionText; 
    public Text typeText;

    void Start()
    {
        displayCard[0] = CardsDataBase.cardList[displayId];
        System.Console.WriteLine(displayCard[0].id);
    }

    void Update()
    {
        Id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cardDescription = displayCard[0].cardDescription;
        cardType = displayCard[0].cardType;

        nameText.text = " " + cardName;
        descriptionText.text = " " + cardDescription;
        typeText.text = " " + cardType;
    }



}
