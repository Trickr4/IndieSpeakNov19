using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{

    public Sprite icon;
    public enum Type {Action, Field }
    public Type type;
    public string cardDuration;
    public int cardValue;
    [TextArea]
    public string description;

    [HideInInspector]
    public GameObject itemObject;

}