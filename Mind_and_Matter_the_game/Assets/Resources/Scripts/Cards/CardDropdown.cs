using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SA;
using CardRef;


namespace CardMenu
{
    public class CardDropdown : MonoBehaviour
    {
        public static List<Card> allCards = new List<Card>();
        public Dropdown dropdown;
        public Text selectedName;
        public CardFilter filter;
        public static Card selectedCard;
        private CardList selectedCards = new CardList();
        List<string> CardNames = new List<string>();

        public void SearchFieldChanged()
        {
            selectedCards = filter.LoadSelection();
            PopulateList();
        }

        public void DropdownIndexChanged(int index)
        {
            selectedName.text = selectedCards.cards[index].getName();
            selectedCard = selectedCards.cards[index];
            //selectedName.text = CardReference.allCardNames[index];
            //selectedCard = CardReference.allCards[index];
        }

        // Start is called before the first frame update
        void Start()
        {
            selectedCards.cards = CardReference.allCards;
            selectedName.text = selectedCards.cards[0].getName();
            selectedCard = selectedCards.cards[0];
            //selectedName.text = CardReference.allCardNames[0];
            //selectedCard = CardReference.allCards[0];
            PopulateList();
        }

        void PopulateList()
        {
            dropdown.ClearOptions();
            dropdown.AddOptions(selectedCards.getNames());
        }

        public Card GetSelectedCard()
        {
            return selectedCard;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}