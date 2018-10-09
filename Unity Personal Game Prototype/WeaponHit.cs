using UnityEngine;
using System.Collections;

public class WeaponHit : MonoBehaviour
{
    public bool AttackCollision = false;
    int AttackOneHash;
    int AttackTwoHash;
    int AttackThreeHash;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        int sadf = 324;
        if (gameObject.transform.root.gameObject.tag == "Player")
        {
           /* GetComponent<Animator>().GetCurrentAnimatorClipInfo()
            int hash = GetComponent<Animator>().GetHashCode();
            string af = GetComponent<Animator>().animation.name;
            foreach (AnimationState anim in GetComponent<Animator>().GetHashCode())
            {
                if (animation.IsPlaying(anim.name))
                {
                    return anim.name;
                }
            }*/
        }
            //Debug.Log(GetComponent<Animator>().GetCurrentAnimatorClipInfo(0).is);
        /*if(GetComponent<Animation>().animation.name)
        {
            int adsf = 234;
        }*/

        if (col.transform.GetComponent<BaseCharObject>() == true)
        {

            if (col.transform.root.gameObject.name != gameObject.transform.root.gameObject.name)
            {

 
                    if (col.gameObject.tag == "Enemy")
                    {
                        
                        col.gameObject.GetComponent<BaseCharObject>().TakeDamage(gameObject.transform.root.gameObject.GetComponent<BaseCharObject>().ATK - col.gameObject.GetComponent<BaseCharObject>().DEF);
                    }

                }
                 if (col.gameObject.tag == "Player")
                {
                    col.gameObject.GetComponent<BaseCharObject>().TakeDamage(4);
                }
            

        }



        // if (col.gameObject.GetComponent<BaseCharObject>() == true)
        //  {
        //   col.gameObject.GetComponent<BaseCharObject>().TakeDamage(4);
        // Physics.IgnoreCollision(col, transform.parent.GetComponent<Collider>());
        //  }
        /*if (AttackCollision == true)
        {
            if (col.collider.tag == "Enemy")
            {
                // if (col.transform.GetComponent<HealthScript>() == true)
                // {
                /* HealthScript health = col.gameObject.GetComponent<HealthScript>();
                 if (health)
                 {
                     health.TakeDamage(4);
                 }*/
        //  }
        // }
        //  }*/
    }
    public void SetAttackCollision(bool Collision)
    {
        AttackCollision = Collision;
    }

}
