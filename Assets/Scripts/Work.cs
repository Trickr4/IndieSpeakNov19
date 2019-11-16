using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    bool talk= true;

    public List<NPC> people;
    NPC person;

    DialogueManager dialogue;

    GameObject dialogueManager;

    private void Start()
    {
        dialogueManager = GameObject.Find("DialogueManager");
        dialogue = dialogueManager.GetComponent<DialogueManager>();
    }

    void OnEnable()
    {
        person = people[Random.Range(0, people.Count)];
        talk = true;
    }

    void OnDisable()
    {
        person = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (talk)
        {
            talk = false;
            dialogue.levelDialogue = new List<string>() { person.dialouge[Random.Range(0, person.dialouge.Count)] };
            dialogue.StartDialogue();
        }
    }

}
