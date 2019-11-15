using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{

    public Sprite icon;
    public string cardName;
    public string type;
    public string cardDuration;
    public string cardValue;
    [TextArea]
    public string description;

    [HideInInspector]
    public GameObject itemObject;

}