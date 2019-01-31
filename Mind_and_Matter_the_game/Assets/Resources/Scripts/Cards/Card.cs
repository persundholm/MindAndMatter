using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        public CardProperties[] properties;
        public CardType cardType;


        //Function that gets an element property in and returns the property that matches the element.
        //If the element is not matched by the properties, it returns null.
        public CardProperties SearchProperty(Element searchedElement)
        {
            CardProperties matchingProperty = null;
            foreach (CardProperties cp in properties)
            {
                if(cp.element == searchedElement)
                {
                    matchingProperty = cp;
                    return matchingProperty;
                }
            }
            return matchingProperty;
        }

        public string getName()
        {
            //Extract name 
            ElementText nameElement = Resources.Load("Data/Elements/Name") as ElementText;
            CardProperties nameProperty = SearchProperty(nameElement);
            string cardName = nameProperty.stringValue;
            return cardName;
        }
    }
}