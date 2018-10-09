using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SeletionCount : MonoBehaviour {
    public int Count = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Count == 0)
        {
            GameObject.Find("TestCanvas").GetComponent<HidePanel>().SetUIFlag(true);
            GameObject.Find("MessagingText").GetComponent<Text>().text = "You Win!";
        }
	}
   public void KillSkeleton()
    {
        Count -= 1;
    }
}
