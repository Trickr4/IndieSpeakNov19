using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardInteration : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    GameObject GameManager;
    Hand hand;
    

    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        hand = GameManager.GetComponent<Hand>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log(name + " Game Object Clicked!");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log(name + " Game Object Clicked!");
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        CardDisplay selected = pointerEventData.pointerPress.GetComponent<CardDisplay>();
        
        if (hand.chose)
        {
            Debug.Log(selected + " Game Object Clicked!");
            if (pointerEventData.button == PointerEventData.InputButton.Left)
            {
                /*
                if (inDialogue)
                    UseCard(selected.card);
                if (inShop)
                    BuyCard(selected.card);
                */
            }
            if (pointerEventData.button == PointerEventData.InputButton.Right)
            {
                //InspectCard(pointerEventData.pointerPress);
                UseCard(selected.card);
                hand.HideHand();
                hand.RemoveCard(selected.card);
                Destroy(selected.gameObject);
                hand.cardUsed = true;
            }
        }
    }

    void InspectCard( GameObject card )
    {

    }

    void BuyCard( Card subject )
    {
        //Debug.Log(subject);
        if (subject.type == Card.Type.Action)
            GameManager.GetComponentsInChildren<Deck>()[0].AddActionCard(subject);
        else if (subject.type == Card.Type.Field)
            GameManager.GetComponentsInChildren<Deck>()[0].AddFieldCard(subject);
    }

    void UseCard(Card subject)
    {
        //Debug.Log(subject);
        Player player = GameManager.GetComponentsInChildren<Player>()[0];
        player.Action(subject);
    }

    void ViewCard( Card subject )
    {

    }
}
