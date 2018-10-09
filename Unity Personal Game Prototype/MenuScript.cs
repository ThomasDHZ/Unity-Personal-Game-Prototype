using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public PS3Controller Controller;
    public GUISkin Skin;
    public string[] MenuText;
    public int LineSpacing = 35;
    public int CursorSelection = 0;
    public int asdf = 0;

    public float BaseTimer = .25F;
    public float Timer = .25F;

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update ()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            CursorSelection += Mathf.RoundToInt(Controller.DPadYButton);
            Timer = BaseTimer;
        }

        if(CursorSelection > MenuText.Length-1)
        {
            CursorSelection = 0;
        }
        else if(CursorSelection < 0)
        {
            CursorSelection = MenuText.Length-1;
        }

        if(Controller.XButton)
        {
            MenuChoiceSelected(CursorSelection);
        }

    }
    void OnGUI()
    {
            int y = LineSpacing;
            GUI.skin = Skin;
            GUI.BeginGroup(new Rect(0, 0, Screen.width, Screen.height));
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
            for (int x = 0; x < MenuText.Length; x++)
            {
                if (GUI.Button(new Rect(Screen.width / 4, y, 500, 35), ""))
                {
                    MenuChoiceSelected(x);
                }
                GUI.Label(new Rect(230, (LineSpacing / 8) + y, 600, 35), MenuText[x]);
                y += 35;
            }
            GUI.EndGroup();
    }
    void MenuChoiceSelected(int selected)
    {
        switch(selected)
        {
            case 0: SceneManager.LoadScene(1); break;
            case 1: Application.Quit(); break;
        }
    }
}
