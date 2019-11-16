using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsDisplay : MonoBehaviour
{

    Player player;
    GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        player = gameManager.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
