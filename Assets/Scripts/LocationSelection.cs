using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LocationSelection : MonoBehaviour, IPointerClickHandler
{
    Canvas template;
    public GameObject location;
    GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        
        template = transform.parent.gameObject.GetComponentInParent(typeof(Canvas)) as Canvas;
        GameManager = GameObject.Find("GameManager");
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        DayCycle day = GameManager.GetComponent<DayCycle>();
        Debug.Log(name + " Game Object Clicked!");
        template.gameObject.SetActive(false);
        DialogueManager l = location.GetComponentsInChildren<DialogueManager>()[0];
        l.levelDialogue = GameManager.GetComponent<Boss>().Speak();
        l.StartDialogue();
        day.StartDay();
    }
}