using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BaseCharObject : MonoBehaviour
{

    public GameObject CharWeapon;

    public int Level = 1;
    public int MaxHP;
    public int MaxMP;
    public int MaxSP;
    public int HP;
    public int MP;
    public int SP;
    public int ATK;
    public int DEF;
    public int INT;
    public int RES;
    public int SPD;
    public int EXP;

    float Timer = 0;
    float DestoryTime = 1.5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            GetComponent<Animator>().SetBool("DeathFlag", true);
            Timer += Time.deltaTime;
            if (Timer > DestoryTime)
            {
                if (gameObject.tag == "Player")
                {
                    GameObject.Find("TestCanvas").GetComponent<HidePanel>().SetUIFlag(true);
                    GameObject.Find("MessagingText").GetComponent<Text>().text = "You Lose";
                    Destroy(gameObject);
                }
                else
                {
                   // GameObject.Find("SkeleCount").GetComponent<SeletionCount>().KillSkeleton();
                    Destroy(gameObject);
                }
              
            }
        }
    }
    public void TakeDamage(int dmg)
    {
      //  GameObject.Find("PopUpCanvas").GetComponent<FloatingTextController>().CreateFloatingText(dmg.ToString(), transform);
        //GetComponent<Animator>().SetBool("HitFlag", true);
        HP -= dmg;
    }
}
