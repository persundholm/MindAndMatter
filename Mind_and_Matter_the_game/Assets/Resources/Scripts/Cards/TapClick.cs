using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

//This class is for tilting the card 90 degrees clockwise when tapping a card

public class TapClick : MonoBehaviour, IPointerClickHandler
{
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //Get the card's geometric attributes
            RectTransform rectTransform = GetComponent<RectTransform>();
            //Rotate clockwise if untapped
            if(rectTransform.rotation.z==0)
            {
                rectTransform.Rotate(new Vector3(0, 0, -90));
            }
            else
            {
                //Rotate counter clockwise if tapped
                rectTransform.Rotate(new Vector3(0, 0, 90));
            }
            
            Debug.Log(name + " Game Object Clicked!");
        }
            
    }
}
