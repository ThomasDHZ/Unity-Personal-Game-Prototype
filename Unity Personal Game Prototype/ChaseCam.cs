using UnityEngine;
using System.Collections;

public class ChaseCam : MonoBehaviour {
    public Transform PlayerTransform;
    public Vector3 CameraOffset = new Vector3(0, 1.56F,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(PlayerTransform.position.x + CameraOffset.x, PlayerTransform.position.y + CameraOffset.y, CameraOffset.z); 
    }
}
