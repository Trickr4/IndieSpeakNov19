using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new NPC", menuName = "NPC")]
public class NPC : ScriptableObject
{
    public string alias;
    public List<string> dialouge;

    [HideInInspector]
    public GameObject itemObject;

}