using UnityEngine;
using System.Collections;

public class GetModelSize : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //GetComponent<CapsuleCollider>().transform.position = gameObject.transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.
        GetComponent<CapsuleCollider>().transform.rotation = gameObject.transform.rotation;
        Debug.Log(GetComponent<MeshFilter>().mesh.bounds.size);
    }
}
