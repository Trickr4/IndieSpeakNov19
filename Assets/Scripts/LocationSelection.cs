using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LocationSelection : MonoBehaviour, IPointerClickHandler
{
    Canvas template;

    // Start is called before the first frame update
    void Start()
    {
        template = gameObject.GetComponentInParent(typeof(Canvas)) as Canvas;
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log(name + " Game Object Clicked!");
        template.gameObject.SetActive(false);
    }
}
