using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyCard : MonoBehaviour, IPointerClickHandler
{
    public GameObject gameObj;
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Destroy(gameObj);

            Debug.Log(name + " Game Object Destroyed!");
        }



    }
}
