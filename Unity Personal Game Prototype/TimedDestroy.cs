using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour {
    public float Timer = 0.0f;
    public float DestoryTime = 1.5f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > DestoryTime)
        {
            Destroy(gameObject);
        }
    }
}
