using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LocationSelection : MonoBehaviour, IPointerClickHandler
{
    GameObject template;
    public GameObject location;
    GameObject GameManager;
    GameLoop loop;
    CanvasManager canvas;

    // Start is called before the first frame update
    void Start()
    {
        //.GetComponentInParent(typeof(Canvas)) as Canvas
        template = transform.parent.gameObject;
        GameManager = GameObject.Find("GameManager");
        loop = GameManager.GetComponent<GameLoop>();
        canvas = GameManager.GetComponent<CanvasManager>();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {

        Debug.Log(template + " Game Object Clicked!");
        canvas.SwitchTo(template, GameObject.Find("Hand"));
        loop.SetLocation(location.name);
        /*
        DialogueManager l = location.GetComponentsInChildren<DialogueManager>()[0];
        l.levelDialogue = GameManager.GetComponent<Boss>().Speak();
        l.StartDialogue();
        */
    }
}