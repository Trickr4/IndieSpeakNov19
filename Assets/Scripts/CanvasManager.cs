using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] Image FadeImage;
    bool loadFinish = false;
    public bool pauseInput = false;
    GameLoop loop;
    Player player;
    GameObject GameManager;
    DayCycle day;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        loop = GameManager.GetComponent<GameLoop>();
        player = GameManager.GetComponent<Player>();
        day = GameManager.GetComponent<DayCycle>();
    }

    public void SwitchTo(GameObject from, GameObject To)
    {
        GameObject GameManager = GameObject.Find("GameManager");
        Player player = GameManager.GetComponent<Player>();
        if (player.ViewEnergy() == 0)
        {
            day.EndDay();
            StartCoroutine(FadeIn(from, GameObject.Find("Homes")));
            GameObject.Find("Homes").GetComponents<MonoBehaviour>()[2].enabled = true;
        }
        else
            StartCoroutine(FadeIn(from, To));

    }
    
    

    IEnumerator FadeIn(GameObject from, GameObject to)
    {
        Color change = FadeImage.color;
        pauseInput = true;
        yield return new WaitForSecondsRealtime(1);
        while (FadeImage.color.a < 1 && loadFinish == false)
        {
            change.a += Time.deltaTime;
            FadeImage.color = change;
            
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
            to.GetComponent<Canvas>().enabled = true;
            if (FadeImage.color.a <= 0)
            {
                loadFinish = false;
                pauseInput = false;
            }
        }
        if (player.ViewEnergy() == 0)
        {
            loop.startDay = true;
            player.AddEnergy(2);
        }

    }
}
