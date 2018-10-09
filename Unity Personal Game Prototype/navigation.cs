using UnityEngine;
using System.Collections;

public class navigation : MonoBehaviour {
    UnityEngine.AI.NavMeshAgent agent;

    public Vector3 TargetPos;
    // Use this for initialization
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(TargetPos);
    }
}
