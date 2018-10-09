using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
    public bool MenuFlag;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void SetMenuFlag(bool menuFlag)
    {
        MenuFlag = menuFlag;
    }
    public bool GetMenuFlag()
    {
        return MenuFlag;
    }
}
