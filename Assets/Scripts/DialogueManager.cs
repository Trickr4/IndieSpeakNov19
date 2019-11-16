using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] TextMeshProUGUI dialogueText;
    public List<string> levelDialogue;

    public UnityEvent done;


    bool started = true;
    public bool ended = false;

    bool waitingToContinue = false;
    bool doneWithDialogue = false;
    bool entered = false;

    GameObject gameManager;
    Hand hand;
    CanvasManager canvas;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        hand = gameManager.GetComponent<Hand>();
        canvas = gameManager.GetComponent<CanvasManager>();
    }


    void Update()
    {
        /*
        if (!started && Input.GetKeyDown(KeyCode.P))
        {
            Done();
        }
        */
        if (waitingToContinue)
        {
            if (Input.GetKeyDown(KeyCode.Space) && !canvas.pauseInput)
            {
                if (!doneWithDialogue)
                {
                    waitingToContinue = false;
                    StartCoroutine(ReadLine());
                }
                else if (doneWithDialogue && hand.cardUsed == false)
                {
                    hand.DisplayHand();
                }
                if (hand.cardUsed)
                {
                    Done();
                    hand.cardUsed = false;
                    ended = true;
                }
            }
        }
    }

    public void StartDialogue()
    {
        started = false;
        dialoguePanel.SetActive(true);
        StartCoroutine(ReadLine());
    }

    void Done()
    {
        waitingToContinue = false;
        dialoguePanel.SetActive(false);
    }

    void NextLine()
    {
        StopCoroutine(ReadLine());
        levelDialogue.RemoveAt(0);
        if (levelDialogue.Count == 0)
        {
            doneWithDialogue = true;
        }
        waitingToContinue = true;
    }

    IEnumerator ReadLine()
    {
        dialogueText.text = "";
        string l = levelDialogue[0];
        for (int i = 0; i < l.Length; ++i)
        {
            dialogueText.text += l[i];
            yield return new WaitForSeconds(0.01f);
        }
        NextLine();
    }

}