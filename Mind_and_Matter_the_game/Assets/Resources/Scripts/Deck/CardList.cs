using UnityEngine;
using System.Collections.Generic;

namespace SA
{

    public class CardList 
    {

        public List<Card> cards=new List<Card>();

        public List<string> getNames()
        {
            List < string > listOfNames = new List<string>();
            foreach(Card card in cards)
            {
                listOfNames.Add(card.getName());
            }
            return listOfNames;
        }

    }

}
