using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Camera Cam;
    public Vector3 CameraOffset;
    public Vector3 CameraRotateOffset;
    public float CameraSpeed = 2;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      //  float CameraX = Input.GetAxis("Camera X");
       // float CameraY = Input.GetAxis("Camera Y");

        Cam.transform.position = new Vector3(gameObject.transform.position.x + CameraOffset.x, gameObject.transform.position.y + CameraOffset.y, gameObject.transform.position.z + CameraOffset.z);

        //CameraRotateOffset = new Vector3(CameraX * CameraSpeed, CameraY * CameraSpeed , 0);
        //Cam.transform.localRotation = Quaternion.LookRotation((CameraRotateOffset/5) * Time.fixedDeltaTime);
    }
}
