using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour
{
    GameObject GameManager;


    bool startDay = true;
    bool dialoguePlaying = false;

    DayCycle day;
    Player player;
    DialogueManager dialogue;
    CanvasManager canvas;

    string location;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        dialogue = GameManager.GetComponent<DialogueManager>();
        day = GameManager.GetComponent<DayCycle>();
        player = GameManager.GetComponent<Player>();
        canvas = GameManager.GetComponent<CanvasManager>();
    }



    // Update is called once per frame
    

    void Update()
    {
        
        if (startDay)
        {

            day.StartDay();
            startDay = false;
            //morning dialougue
            //cut into a day num screen
            canvas.SwitchTo(GameObject.Find("Homes"), GameObject.Find("Map"));
        }
        
        if (player.ViewEnergy() == 0)
        {
            day.EndDay();
            player.AddEnergy(2);
            startDay = true;
        }
        
    }
    
    

}
