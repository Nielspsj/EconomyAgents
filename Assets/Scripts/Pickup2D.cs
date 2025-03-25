using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup2D : MonoBehaviour
{
    public List<string> inventoryList = new List<string>();
    private GameObject pickedUpItem;
    public List<GameObject> inventoryObjList = new List<GameObject>();


    private void AddToInventory()
    {
        inventoryList.Add(pickedUpItem.name);
        inventoryObjList.Add(pickedUpItem);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Pickup")
        {
            pickedUpItem = other.gameObject;
            AddToInventory();
            //Hide for now. Destroy when using it to craft.
            other.gameObject.SetActive(false);
        }
    }
}
