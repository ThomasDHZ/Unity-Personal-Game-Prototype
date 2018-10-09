using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageScript : MonoBehaviour {

    public PS3Controller Controller;
    public GUISkin Skin;

    public int LineSpacing = 35;
    public int CursorSelection = 0;

    public float BaseTimer = 1;
    public float Timer = 1;

    public bool MenuFlag = false;
    public bool TimerStart = false;
    public string Message;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (TimerStart == true)
        {
            Timer -= Time.deltaTime;
            if (Timer < 0)
            {
                MenuFlag = false;
                TimerStart = false;
                Timer = BaseTimer;
            }
        }
    }
    void OnGUI()
    {
        if (MenuFlag == true)
        {
            GUI.skin = Skin;
            GUI.BeginGroup(new Rect(0, 0, Screen.width, Screen.height));
            if (GUI.Button(new Rect(983/4, 578/2, 500, 35), ""))
            {
                MenuChoiceSelected();
            }
            GUI.Label(new Rect(983 / 4 - 30, 578 / 2 +5, 600, 35), Message);
            GUI.EndGroup();
        }
    }
    void MenuChoiceSelected()
    {
        MenuFlag = false;
    }
    public void OpenMessage(string message)
    {
        TimerStart = true;
        Message = message;
        MenuFlag = true;
    }
    public void OpenMessage(Items.ItemList message)
    {
        TimerStart = true;
        Message = "Item Get: " + message.ToString();
        MenuFlag = true;
    }
}
