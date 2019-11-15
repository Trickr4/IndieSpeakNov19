using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int charisma;
    int energy;

    // Start is called before the first frame update
    void Start()
    {
        energy = 3;
        charisma = 0;
    }

    public void Action( Card effect )
    {
        Debug.Log("ENergy " + energy);
        if (energy > 0)
        {
            energy -= 1;
            charisma += effect.cardValue;
        }
    }
}
