using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Image icon;
    
    public void Setup(Card _card)
    {
        card = _card;
        icon.sprite = card.icon;
        name = _card.name;
    }
}
