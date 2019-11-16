using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    bool talk= true;

    public List<NPC> people;
    NPC person;
    public GameObject TopDog;
    public GameObject Aiko;

    GameObject chosen;
    DialogueManager dialogue;
    CanvasManager canvas;
    GameObject gameManager;
    Player player;

    GameObject dialogueManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        dialogueManager = GameObject.Find("DialogueManager");
        dialogue = dialogueManager.GetComponent<DialogueManager>();
        player = gameManager.GetComponent<Player>();
        canvas = gameManager.GetComponent<CanvasManager>();
    }

    void OnEnable()
    {
        
        person = people[Random.Range(0, people.Count)];
        Debug.Log(person);
        if (person.name == TopDog.name)
        {
            TopDog.SetActive(true);
            chosen = TopDog;
        }
        if (person.name == Aiko.name)
        {
            Aiko.SetActive(true);
            chosen = Aiko;
        }
        talk = true;
    }

    void OnDisable()
    {
        person = null;
        chosen.SetActive(false);
        chosen = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (talk)
        {
            talk = false;
            dialogue.levelDialogue = new List<string>() { person.dialouge[Random.Range(0, person.dialouge.Count)] };
            //Debug.Log(dialogue.levelDialogue[0]);
            dialogue.StartDialogue();
        }
        if(dialogue.ended)
        {
            Debug.Log(person);
            dialogue.ended = false;
            this.enabled = false;
            player.AddBalance(player.GetSalary());
            canvas.SwitchTo(GameObject.Find(name), GameObject.Find("Map"));
        }
        
    }

}
