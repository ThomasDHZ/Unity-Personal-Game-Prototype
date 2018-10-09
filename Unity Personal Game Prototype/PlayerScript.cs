using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public PS3Controller Controller;
    public Camera camera;
    public float CameraSpeed;

    public int Speed;
    public Vector3 movement;
    public bool Jumping = false;
    public bool WallTrigger = false;
    public float checking;
    public float Degrees;

    public bool DamageFlagInfo;
    public bool IdleFlagInfo;
    public bool Idle2FlagInfo;
    public bool Idle3FlagInfo;
    public bool JumpFlagInfo;
    public bool Attack1FlagInfo;
    public bool Attack2FlagInfo;
    public bool Attack3FlagInfo;
    public bool DeathFlagInfo;

    float LeftStickX;
    float LeftStickY;
    float RightStickX;
    float RightStickY;
    float h;
    float v;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LeftStickX = Controller.LeftStickXMove;
        LeftStickY = Controller.LeftStickYMove;
        RightStickX = Controller.RightStickXMove;
        RightStickY = Controller.RightStickYMove;

        //Vector3 MoveCamera = (new Vector3(-RightStickY * CameraSpeed, -RightStickX * CameraSpeed, 0)) * Time.fixedDeltaTime;
        float XAxisRot = RightStickX * CameraSpeed;
        float YAxisRot = RightStickY * CameraSpeed;

        camera.transform.Rotate(-YAxisRot, XAxisRot, 0);
        float z = camera.transform.eulerAngles.z;
        camera.transform.Rotate(0, 0, -z);

        UpdateFlags();
        Move();
        ControlUpdate();
    }
    void Move()
    {

        if (DamageFlagInfo == false)
        {

            if (WallTrigger == false)
            {
                h = Input.GetAxis("Horizontal");
                v = Input.GetAxis("Vertical");
                GetComponent<Rigidbody>().useGravity = true;
                movement = new Vector3(h * Speed, 0, v * Speed);
            }
            else
            {
                GetComponent<Rigidbody>().useGravity = false;
                // movement = new Vector3(LeftStickX * Speed, LeftStickY * Speed, 0);
            }

            transform.localPosition += movement * Time.fixedDeltaTime;

        }

    }
    void UpdateFlags()
    {

        DamageFlagInfo = GetComponent<Animator>().GetBool("DamageFlag");
        IdleFlagInfo = GetComponent<Animator>().GetBool("IdleFlag");
        Idle2FlagInfo = GetComponent<Animator>().GetBool("Idle2Flag");
        Idle3FlagInfo = GetComponent<Animator>().GetBool("Idle3Flag");
        JumpFlagInfo = GetComponent<Animator>().GetBool("JumpFlag");
        Attack1FlagInfo = GetComponent<Animator>().GetBool("Attack1Flag");
        Attack2FlagInfo = GetComponent<Animator>().GetBool("Attack2Flag");
        Attack3FlagInfo = GetComponent<Animator>().GetBool("Attack3Flag");
        DeathFlagInfo = GetComponent<Animator>().GetBool("DeathFlag");
    }
    void ControlUpdate()
    {

        if (h == 0 && v == 0)
        {
            GetComponent<Animator>().SetBool("IdleFlag", true);
        }
        else
        {
            if (WallTrigger == false)
            {
                GetComponent<Animator>().SetBool("IdleFlag", false);
                transform.localRotation = Quaternion.LookRotation(movement);
            }
        }

        if (Controller.XButton || Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("JumpFlag", true);
        }

        /*  if ((Controller.SquareButton || Input.GetKeyDown(KeyCode.Z)) && GetComponent<Animator>().GetBool("Attack2Flag") == true)
          {
              GetComponent<Animator>().SetBool("Attack3Flag", true);
          }
          else if ((Controller.SquareButton || Input.GetKeyDown(KeyCode.Z)) && GetComponent<Animator>().GetBool("Attack1Flag") == true)
          {
              GetComponent<Animator>().SetBool("Attack2Flag", true);
          }*/
        if (Controller.SquareButton || Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("Attack1Flag", true);
        }

    }
    /*  void OnCollisionEnter(Collision col)
      {
      }
      void OnCollisionStay(Collision col)
      {
          if (col.gameObject.tag == "Chest")
          {
              if (Input.GetButtonDown("Jump"))
              {
                  Debug.Log("Opened Chest");
              }
          }

          if (col.gameObject.tag == "Chest")
          {
                  WallTrigger = true;
          }
          else
          {
              WallTrigger = false;
          }
      }*/
    void OnTriggerEnter(Collider col)
    {
        /* if (col.gameObject.tag == "ClimbWall")
         {
             WallTrigger = true;
         }
         else
         {
             WallTrigger = false;
         }*/
    }
    void OnTriggerStay(Collider col)
    {

        if (col.gameObject.tag == "Chest")
        {
            if (Controller.XButton || Input.GetKeyDown(KeyCode.Space))
            {
                col.gameObject.GetComponent<TreasureChest>().OpenChest();
            }
        }
        else if (col.gameObject.tag == "Collectible")
        {
            col.gameObject.GetComponent<FindItem>().FoundItem();
        } Touch myTouch = Input.touches[0];

    }
}

