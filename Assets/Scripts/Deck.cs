using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

    List<Card> actionDeck;
    List<Card> fieldDeck;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddActionCard(Card newCard)
    {
        actionDeck.Add(newCard);
    }

    void AddFieldCard(Card newCard)
    {
        fieldDeck.Add(newCard);
    }

    Card DrawActionCard()
    {
        return actionDeck[Random.Range(0,actionDeck.Count)];
    }

    Card DrawFieldCard()
    {
        return fieldDeck[Random.Range(0, actionDeck.Count)];
    }
}
