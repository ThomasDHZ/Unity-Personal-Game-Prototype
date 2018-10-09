using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChar : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.GetComponent<BaseCharObject>() == true)
        {
            col.transform.GetComponent<BaseCharObject>().HP = 0;
        }
    }
}
