using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    int numDay;
    GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        numDay = 0;
        GameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndDay()
    {
        numDay += 1;
        Hand hand = GameManager.GetComponent<Hand>();
        hand.EmptyHand();
        //destroy hand
    }

    public void StartDay()
    {
        Hand hand = GameManager.GetComponent<Hand>();
        Deck deck = GameManager.GetComponent<Deck>();
        //card draw
        for (int i = 0; i < 5; i++)
        {
            hand.CardtoHand(deck.DrawActionCard());
        }
        
    }

}
