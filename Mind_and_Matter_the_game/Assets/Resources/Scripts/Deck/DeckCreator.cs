using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SA;
using CardRef;

namespace CardMenu
{ 

    public class DeckCreator : MonoBehaviour
    {

        public CardDropdown cardDropdown;
        public Deck deckUnderConstruction;
        public GameObject cardText;

        public void AddCardToDeck()
        {
            deckUnderConstruction.cards.Add(cardDropdown.GetSelectedCard());
        }

        public void PrintDeckUnderConstruction()
        {
            foreach(Card card in deckUnderConstruction.cards)
            {
                GameObject cardName = Instantiate(cardText, Vector3.zero, Quaternion.identity) as GameObject;
                Text cardNameText=cardName.GetComponent<Text>();
                cardNameText.text = card.getName();
                cardName.transform.SetParent(GameObject.FindGameObjectWithTag("DeckSummary").transform, false);
            }
           
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

}
