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
        bool once = true;
        if (template.GetComponent<Canvas>().enabled && !canvas.pauseInput && once)
        {
            Debug.Log(pointerEventData);
            once = false;
            canvas.SwitchTo(template, GameObject.Find(name+"s"));
            GameObject dest = GameObject.Find(name + "s");
            dest.GetComponents<MonoBehaviour>()[2].enabled = true;
        }
    }
}