using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] List<string> levelDialogue;

    public List<string> Speak()
    {
        return new List<string>() { levelDialogue[Random.Range(0, levelDialogue.Count - 1)] };
    }
}