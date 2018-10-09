using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeleAI : MonoBehaviour {

    public Inventory Inven;
    public MessageScript message;
    public float Distance;
    public int Speed;
    public Vector3 movement;
    Items.ItemList DroppedItem = Items.ItemList.Key;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      //  Distance = Vector3.Distance(gameObject.transform.position, Target.transform.position);
        if (Distance <= 1)
        {
            GetComponent<Animator>().SetBool("AttackFlag", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("AttackFlag", false);
        }
       if(gameObject.GetComponent<BaseCharObject>().HP < 0)
        {
            message.OpenMessage(DroppedItem);
            Inven.AddItem(DroppedItem);
            Destroy(this);
        }
        movement = new Vector3(1 * Speed, 1 * Speed, 1 * Speed);
        transform.localPosition += movement * Time.fixedDeltaTime;
      //  Target.transform.position += gameObject.transform.position;
                

                GetComponent<Animator>().SetFloat("MoveX", 1);

        if (-Speed > 0)
        {
            transform.rotation = Quaternion.AngleAxis(270, Vector3.down);
        }
        else if (-Speed < 0)
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.down);
        }
    }
}
