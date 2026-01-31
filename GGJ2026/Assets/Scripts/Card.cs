using UnityEngine;

[System.Serializable]
public class Card
{
     public int id; 
      public string cardName; 
      public string cardDescription;
      public string cardType;

        //public int cardDamage; added this in case we want to switch things up with the card system in the future


        public Card ()
        {
            
        }


        public Card(int Id, string CardName, string CardDescription, string CardType)
        {
            id = Id;
            cardName = CardName;
            cardDescription = CardDescription;
            cardType = CardType;
        }
}
