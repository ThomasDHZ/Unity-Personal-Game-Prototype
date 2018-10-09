using UnityEngine;
using System.Collections;

public class SwordHit : MonoBehaviour
{
    public bool AttackCollision = false;
    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(AttackCollision);
    }
    void OnCollisionEnter(Collision col)
    {
        if(AttackCollision == true)
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
            }
        }
    }
    public void SetAttackCollision(bool Collision)
    {
        AttackCollision = Collision;
    }

}
