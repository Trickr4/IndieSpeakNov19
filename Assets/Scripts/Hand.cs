using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    List<Card> HandCard;
    public GameObject display;
    GameObject GameManager;
    public GameObject CardPrefab;

    public Transform parentTrans;
    // Start is called before the first frame update
    void Start()
    {
        HandCard = new List<Card>();
        GameManager = GameObject.Find("GameManager");
    }

    void DisplayHand()
    {
        //display = gameObject.transform.GetChild(0).gameObject;
        parentTrans.transform.parent.gameObject.GetComponent<Canvas>().enabled = true;
    }

    void HideHand()
    {
        //display = gameObject.transform.GetChild(0).gameObject;
        parentTrans.transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
    }

    public void CardtoHand( Card sub )
    {
        GameObject card = Instantiate(CardPrefab);
        card.transform.SetParent(parentTrans);
        CardDisplay display = card.GetComponent<CardDisplay>();
        display.Setup(sub);
        HideHand();
        HandCard.Add(sub);
    }

    void RemoveCard( Card sub )
    {
        HandCard.Remove(sub);
    }

    public void EmptyHand()
    {
        HandCard.Clear();
    }

}
