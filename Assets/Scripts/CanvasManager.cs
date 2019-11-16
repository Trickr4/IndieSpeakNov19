using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] Image FadeImage;
    bool loadFinish = false;


    public void SwitchTo(GameObject from, GameObject To)
    {
        
        StartCoroutine(FadeIn(from,To));
        
    }

    /*
    public void ExitCanvas(GameObject scene)
    {
        if (loadFinish)
            StartCoroutine(FadeIn(scene));
    }

    public void EnterCanvas(GameObject scene)
    {
        if (loadFinish)
        {
            scene.GetComponent<Canvas>().enabled = true;
            StartCoroutine(FadeOut());
        }s
    }
    */
    IEnumerator FadeOut(GameObject to)
    {
        Color change = FadeImage.color;
        while (FadeImage.color.a == 1)
        {
            change.a -= Time.deltaTime;
            FadeImage.color = change;
            yield return null;
        }
        to.GetComponent<Canvas>().enabled = true;
    }

    IEnumerator FadeIn(GameObject from, GameObject to)
    {
        Color change = FadeImage.color;
        while (FadeImage.color.a < 1 && loadFinish == false)
        {
            change.a += Time.deltaTime;
            FadeImage.color = change;
            Debug.Log(FadeImage.color.a);
            yield return null;
            if (FadeImage.color.a >= 1)
            {
                loadFinish = true;
                from.GetComponent<Canvas>().enabled = false;
            }
        }
        while (loadFinish && FadeImage.color.a >= 0)
        {
            change.a -= Time.deltaTime;
            FadeImage.color = change;
            yield return null;
            if (FadeImage.color.a <= 0)
            {
                loadFinish = false;

                Debug.Log(from);
                to.GetComponent<Canvas>().enabled = true;
            }
        }

    }
}
