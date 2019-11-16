using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLoop : MonoBehaviour
{
    GameObject GameManager;

    [SerializeField] GameObject DayImage;
    [SerializeField] TextMeshProUGUI DayText;
    [SerializeField] Image FadeImage;

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
            DayText.text = "Day " + day.numDay;
            //morning dialougue
            //cut into a day num screen
            StartCoroutine(FadeIn());
            canvas.SwitchTo(GameObject.Find("Homes"), GameObject.Find("Map"));
        }
        
        if (player.ViewEnergy() == 0)
        {
            day.EndDay();
            player.AddEnergy(2);
            startDay = true;
        }
        
    }

    IEnumerator FadeIn()
    {
        DayImage.GetComponent<Canvas>().enabled = true;
        Color change = FadeImage.color;
        while (FadeImage.color.a < 1)
        {
            change.a += Time.deltaTime;
            FadeImage.color = change;
            
            
        }
        DayImage.GetComponent<Canvas>().enabled = true;
        yield return new WaitForSecondsRealtime(1f);
        DayImage.GetComponent<Canvas>().enabled = false;
        change.a = 0;
        FadeImage.color = change;

    }

}
