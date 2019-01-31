using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardRef;
using UnityEngine.UI;
using Extensions;
using System;

namespace SA
{

    public class CardFilter : MonoBehaviour
    {

        public Text searchedNameText;
        public CardList LoadSelection()
        {
            string searchedName = searchedNameText.text;
           CardList matchingCards = new CardList();

            foreach (Card card in CardReference.allCards)
            {
                //Search for specific card name
                string cardName = card.getName();
                //String match
                if (cardName.Contains(searchedName, StringComparison.OrdinalIgnoreCase))
                {
                    matchingCards.cards.Add(card);
                }
                
            }

            return matchingCards;
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
