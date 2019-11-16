using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    bool talk = true;
    DialogueManager dialogue;
    CanvasManager canvas;
    GameObject gameManager;

    [SerializeField]List<string> text;

    GameObject dialogueManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        dialogueManager = GameObject.Find("DialogueManager");
        dialogue = dialogueManager.GetComponent<DialogueManager>();
        canvas = gameManager.GetComponent<CanvasManager>();
    }

    void OnEnable()
    {
        talk = true;
    }

    void OnDisable()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (talk)
        {
            talk = false;
            dialogue.levelDialogue = new List<string>() { text[0] };
            //Debug.Log(dialogue.levelDialogue[0]);
            dialogue.StartDialogue();
        }
        if (dialogue.ended)
        {
            dialogue.ended = false;
            this.enabled = false;
            canvas.SwitchTo(GameObject.Find("Homes"), GameObject.Find("Map"));
        }

    }

}