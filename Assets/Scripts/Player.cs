using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    float salary = 11f;
    float balance = 0f;

    float charisma;
    int energy;
    float motivation;
    [SerializeField] Image moBar;
    [SerializeField] Image chBar;
    [SerializeField] TextMeshProUGUI money;
    [SerializeField] TextMeshProUGUI rate;

    // Start is called before the first frame update
    void Start()
    {
        energy = 3;
        charisma = 10f;
        motivation = 10f;
        rate.text = salary + "/HR";
        money.text = "" + balance;
    }

    void Update()
    {
        chBar.fillAmount = charisma / 50;
        moBar.fillAmount = motivation / 50;
    }

    public float GetSalary()
    {
        return salary;
    }

    public void SetSalary(float n)
    {
        salary = n;
        rate.text = salary + "//HR";

    }

    public float GetBalance()
    {
        return balance;
    }

    public void AddBalance(float n)
    {
        balance += n;
        money.text = "" + balance;
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
