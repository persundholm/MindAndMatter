using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SA;
using CardRef;
using CardMenu;

public class GenerateCard : MonoBehaviour
{
    public GameObject CardTemplate;


    public void CreateCard()
    {
        GameObject newCard = Instantiate(CardTemplate, Vector3.zero, Quaternion.identity) as GameObject;
        newCard.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        CardViz v = newCard.GetComponent<CardViz>();
        v.LoadCard(CardDropdown.selectedCard);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
