using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Image icon;
    public TextMeshProUGUI title;
    
    public void Setup(Card _card)
    {
        card = _card;
        icon.sprite = card.icon;
        title.text = _card.name;
        name = _card.name;

    }
}
