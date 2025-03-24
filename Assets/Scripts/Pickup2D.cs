using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup2D : MonoBehaviour
{
    public List<string> inventoryList = new List<string>();
    private GameObject pickedUpItem;
   

    private void AddToInventory()
    {
        inventoryList.Add(pickedUpItem.name);
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
