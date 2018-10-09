using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour {
    public ChestCount Chestcounterobject;
    public Inventory Inven;
    public MessageScript message;
    public Items.ItemList ChestItem;
    bool OpenFlag = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OpenChest()
    {
        if (OpenFlag == false)
        {
            bool keyfound = false;
            foreach (Items itemz in Inven.ItemList)
            {
                if (itemz.Name == "Key")
                {
                    if (itemz.Amt > 0)
                    {
                        keyfound = true;
                    }
                }
            }

            if (keyfound == false)
            {
                message.OpenMessage("You need a key.");
            }
            else
            {
                if (OpenFlag == false)
                {
                    GetComponent<AudioSource>().Play();
                    GetComponent<Animation>().Play();
                    message.OpenMessage(ChestItem);
                    Inven.AddItem(ChestItem);
                    Inven.UseItem(Items.ItemList.Key);
                    OpenFlag = true;
                    Chestcounterobject.ChestOpenedd();
                }
                Debug.Log(gameObject.name);
            }
        }
    }
}
