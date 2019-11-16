using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    float charisma;
    int energy;
    [SerializeField] Image bar;

    // Start is called before the first frame update
    void Start()
    {
        energy = 2;
        charisma = 10f;
    }

    void Update()
    {
        bar.fillAmount = charisma / 20;
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

    public int ViewEnergy()
    {
        return energy;
    }

    public void AddEnergy(int num)
    {
        energy += num;
    }
}
