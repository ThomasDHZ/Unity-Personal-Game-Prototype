using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestCount : MonoBehaviour {
    public int ChestCounter = 10;
    public MessageScript messager;

    public bool StartTimer = false;
    public float BaseTimer = 1;
    public float Timer = 1;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (StartTimer == true)
        {
            Timer -= Time.deltaTime;
            if (Timer < 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
    public void ChestOpenedd()
    {
        ChestCounter -= 1;
        if(ChestCounter == 0)
        {
            messager.OpenMessage("You Win");
            StartTimer = true;
        }
    }
}
