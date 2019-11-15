using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

    List<Card> actionDeck;
    List<Card> fieldDeck;

    public Card test;



    // Start is called before the first frame update
    void Start()
    {
        //actionDeck = new List<Card>();
        actionDeck = new List<Card>() {test};
        fieldDeck = new List<Card>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddActionCard(Card newCard)
    {
        actionDeck.Add(newCard);
        Debug.Log("Action Deck: " + actionDeck.Count);
    }

    public void AddFieldCard(Card newCard)
    {
        fieldDeck.Add(newCard);
        Debug.Log("Field Deck: " + fieldDeck.Count);
    }

    public Card DrawActionCard()
    {
        Debug.Log(actionDeck[Random.Range(0, actionDeck.Count - 1)]);
        return actionDeck[Random.Range(0,actionDeck.Count-1)];
    }

    public Card DrawFieldCard()
    {
        return fieldDeck[Random.Range(0, actionDeck.Count-1)];
    }
}
