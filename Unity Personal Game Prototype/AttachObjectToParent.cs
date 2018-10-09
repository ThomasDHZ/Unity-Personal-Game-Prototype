using UnityEngine;
using System.Collections;

public class AttachObjectToParent : MonoBehaviour {

    public Transform ObjectParent;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.position = ObjectParent.transform.position;
	}
}
