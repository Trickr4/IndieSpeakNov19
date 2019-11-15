using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardInteration : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(name + " Game Object Clicked!");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(name + " Game Object Clicked!");
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log(name + " Game Object Clicked!");
    }

    void UseCard( Card subject )
    {

    }

    void ViewCard( Card subject )
    {

    }
}
