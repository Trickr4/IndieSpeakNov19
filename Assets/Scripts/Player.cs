using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    float salary = 11f;
    float balance = 0f;

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

    public float GetSalary()
    {
        return salary;
    }

    public void SetSalary(float n)
    {
        salary = n;
    }

    public float GetBalance()
    {
        return balance;
    }

    public void AddBalance(float n)
    {
        balance += n;
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
