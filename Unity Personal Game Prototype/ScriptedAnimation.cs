using UnityEngine;
using System.Collections;

public class ScriptedAnimation : MonoBehaviour {


    private Animator anim;
    private Rigidbody Body;

    private float inputH;
    private float inputV;

    int IdleHash = Animator.StringToHash("Base Layer.Idle");
    int RunHash = Animator.StringToHash("Base Layer.Run");
    int DamageHash = Animator.StringToHash("Base Layer.DAMAGE1");

    int jumpHash = Animator.StringToHash("Jump");
    int runStateHash = Animator.StringToHash("Base Layer.Run");


    void Start()
    {
        anim = GetComponent<Animator>();
        Body = GetComponent<Rigidbody>();

        int zcxv = 234;
    }


    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        float moveX = inputH * 50f * Time.deltaTime;
        float moveZ = inputV * 50f * Time.deltaTime;

       //gameObject.transform.position = new Vector3(gameObject.transform.position.x - moveX, 0, gameObject.transform.position.z - moveZ);

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);

      //  Debug.Log("inputH: " + inputH);
      //  Debug.Log("inputV: " + inputV);

        if(Input.GetMouseButtonDown(0))
        {
            anim.Play("DAMAGED", -1, 0f);
        }



        /*  anim.GetBool();
          float move = Input.GetAxis("Vertical");
          anim.SetFloat("Speed", move);

          AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
          if (Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash)
          {
              anim.SetTrigger(jumpHash);
          }*/
    }
}
