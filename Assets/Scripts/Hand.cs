using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    public List<Card> HandCard;
    public GameObject display;
    GameObject GameManager;
    public GameObject CardPrefab;
    public bool cardUsed = false;
    public bool chose = false;

    public Transform parentTrans;
    // Start is called before the first frame update
    void Start()
    {
        HandCard = new List<Card>();
        GameManager = GameObject.Find("GameManager");
    }

    public void DisplayHand()
    {
        //display = gameObject.transform.GetChild(0).gameObject;
        parentTrans.transform.parent.gameObject.GetComponent<Canvas>().enabled = true;
        chose = true;

    }

    public void HideHand()
    {
        //display = gameObject.transform.GetChild(0).gameObject;
        parentTrans.transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
        chose = false;
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

    public void RemoveCard( Card sub )
    {
        HandCard.Remove(sub);
    }

    public void EmptyHand()
    {
        foreach (Transform c in parentTrans)
            Destroy(c.transform.gameObject);
        HandCard.Clear();
    }

}
