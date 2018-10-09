using UnityEngine;

using System.Collections;
namespace Complete
{
    public class AIMove : MonoBehaviour

    {

        UnityEngine.AI.NavMeshAgent agent;
        public GameObject ObjectChased;
        public Vector3 TargetPos;

        // Use this for initialization
        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(TargetPos);
        }
    }
}
