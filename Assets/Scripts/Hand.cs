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

    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        HandCard = new List<Card>();
        GameManager = GameObject.Find("GameManager");
    }

    void DisplayHand()
    {
        //display = gameObject.transform.GetChild(0).gameObject;
        display.SetActive(true);
    }

    void HideHand()
    {
        //display = gameObject.transform.GetChild(0).gameObject;
        display.SetActive(false);
    }

    public void CardtoHand( Card sub )
    {
        GameObject card = Instantiate(CardPrefab);
        card.transform.SetParent(parent);
        CardDisplay display = card.GetComponent<CardDisplay>();
        display.Setup(sub);
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
