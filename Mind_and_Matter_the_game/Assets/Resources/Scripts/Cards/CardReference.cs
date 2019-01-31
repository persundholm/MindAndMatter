using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SA;

namespace CardRef
{
    public class CardReference : MonoBehaviour
    {
        
        public static List<Card> allCards = new List<Card>();
        public static List<Element> cardElements = new List<Element>();
        public static List<string> allCardNames = new List<string>();


        static CardReference()
        {
            //Important note: place your prefabs folder(or levels or whatever) 
            //in a folder called "Resources" like this "Assets/Resources/Prefabs"
            Object[] subListObjects = Resources.LoadAll("Data/Cards", typeof(Card));
           

            foreach (Card subListObject in subListObjects)
            {
                Card lo = (Card)subListObject;

                allCards.Add(lo);
            }


            Object[] gameElementsObjects = Resources.LoadAll("Data/Elements", typeof(Element));
            //Get all card names in one list
            foreach (Element gameElementsObject in gameElementsObjects)
            {
                Element eo = (Element)gameElementsObject;
                cardElements.Add(eo);
            }

            foreach( Card card in allCards)
            {
                foreach(CardProperties property in card.properties)
                {
                    if (property.element.name == "Name")
                    {
                        allCardNames.Add(property.stringValue);
                    }
                    
                }
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
