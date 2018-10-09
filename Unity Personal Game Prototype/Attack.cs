using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attack : MonoBehaviour {
    Inventory inven;
    public GameObject Chest;
    bool ShowWinMenu = false;
	// Use this for initialization
	void Start () {
        // GameObject.Find("ItemMenuCanvas").GetComponent<HidePanel>().UIFlag = true;
        inven = GameObject.Find("InventoryManager").GetComponent<Inventory>();
    }
	void OnCollisionEnter(Collision col)
	{
		//Debug.Log("You hit something " + col.collider.tag);
		if(col.collider.tag == "Key")
		{
            inven.AddItem(new Key());
            Destroy(col.gameObject);
            GameObject.Find("MessageCanvas").GetComponent<HidePanel>().SetUIFlag(true);
            
        }
        if(col.collider.tag == "Chest")
        {
            int count = 0;
            foreach (Items iteming in inven.ItemList)
            {
                if (iteming.Name == "Key" && iteming.Amt > 0)
                {
                   // iteming.Amt--;
                   // col.gameObject.GetComponent<Animation>().Play();
                  //  inven.ItemList[2].Amt++; 
                    //col.gameObject.GetComponent<Animator>().SetBool("ChestOpenFlag", true);
                }
                count++;
            }
        }	
	}
	// Update is called once per frame
	void Update () {
        if (ShowWinMenu == true)
        {
       //     GameObject.Find("WinCanvas").GetComponent<HidePanel>().SetUIFlag(true);
        }
    }
    void OnMouseDown()
    {
        foreach (Items iteming in inven.ItemList)
        {
            if (iteming.Name == "Key" && iteming.Amt > 0)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    
                    ShowWinMenu = true;
                    Chest.GetComponent<AudioSource>().Play();
                    Chest.GetComponent<Animation>().Play();
                    iteming.Amt--;
                    
                }
            }
        }
    }
}
