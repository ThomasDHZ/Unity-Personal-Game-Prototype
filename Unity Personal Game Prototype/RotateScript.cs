using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {
    private Animator anim;
    public float Speed = 1.0F;
    public float moveHorizontal;
    public bool chec = false;

    private bool IdleCheck = true;

    int RunHash = Animator.StringToHash("Run");
    int IdleHash = Animator.StringToHash("Idle");
    int JumpHash = Animator.StringToHash("Jump");

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.Play(RunHash, -1, 0f);
            transform.rotation = Quaternion.AngleAxis(270, Vector3.down);
            IdleCheck = false;
        }
    }
    void FixedUpdate()
    {
       // AnimatorStateInfo.
       // Debug.Log(AnimatorStateInfo.get)
         moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * Speed;

        // anim.SetFloat("MoveX", moveHorizontal);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.Play(RunHash, -1, 0f);
            transform.rotation = Quaternion.AngleAxis(270, Vector3.down);
            IdleCheck = false;
        }
        if (moveHorizontal < 0)
        {
            anim.Play(RunHash, -1, 0f);
            transform.rotation = Quaternion.AngleAxis(270, Vector3.down);
        }
        else if (moveHorizontal > 0)
        {
            anim.Play(RunHash, -1, 0f);
            transform.rotation = Quaternion.AngleAxis(90, Vector3.down);
        }
        /*if (moveHorizontal != 0)
        {
            chec = moveHorizontal <= -.1;
            Debug.Log(chec);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.Play(RunHash, -1, 0f);
            transform.rotation = Quaternion.AngleAxis(270, Vector3.down);
            IdleCheck = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.Play(RunHash, -1, 0f);
            transform.rotation = Quaternion.AngleAxis(90, Vector3.down);
            IdleCheck = false;
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            anim.Play(JumpHash, -1, 0f);
            transform.rotation = Quaternion.AngleAxis(270, Vector3.down);
            IdleCheck = false;
        }*/
    }
}
