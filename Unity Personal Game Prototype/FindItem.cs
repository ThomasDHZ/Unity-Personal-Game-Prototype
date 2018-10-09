using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindItem : MonoBehaviour
{
    public Inventory Inven;
    public MessageScript message;
    public Items.ItemList ItemFound;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void FoundItem()
    {
        message.OpenMessage(ItemFound);
        Inven.AddItem(ItemFound);
        Destroy(gameObject);
    }
}
